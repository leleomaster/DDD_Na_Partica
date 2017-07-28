using DDD_Na_Partica.Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using DDD_Na_Partica.Domain.Entities;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace DDD_Na_Partica.Infrastructure.Repository.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private string connectionString;
        IDbConnection dbConnection;
        public PessoaRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["connectionStringDapper"].ConnectionString;
            dbConnection = new SqlConnection(connectionString);
        }

        public IEnumerable<TBLPessoa> GetList()
        {
            try
            {
                using (var con = dbConnection)
                {
                    string sql = @"SELECT ID_PESSOA
                                      ,NOME_PESSOA
                                      ,CPF_PESSOA
                                      ,FLAG_ATIVO_PESSOA
                                      ,DATA_CADASTRO_PESSOA
                                  FROM  PESSOA";
                    return con.Query<TBLPessoa>(sql).AsEnumerable();
                }
            }
            catch (Exception ex)
            {
                // Log error: ex.Message + método
            }
            return null;
        }

        public TBLPessoa GetPessoaById(int id)
        {
            try
            {
                using (var con = dbConnection)
                {
                    var parameters = new SqlParameter("@ID_PESSOA", id);

                    string sql = @"SELECT ID_PESSOA
                                      ,NOME_PESSOA
                                      ,CPF_PESSOA
                                      ,FLAG_ATIVO_PESSOA
                                      ,DATA_CADASTRO_PESSOA
                                  FROM  PESSOA
                                  WHERE ID_PESSOA =  @ID_PESSOA
                                ";
                    return con.Query<TBLPessoa>(sql, param: parameters, commandType: CommandType.Text).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                // Log error: ex.Message + método
            }
            return null;
        }

        public int InsertPessoa(TBLPessoa pessoa)
        {
            try
            {
                using (var con = dbConnection)
                {
                    var parameters = new DynamicParameters();

                    parameters.Add("@NOME_PESSOA", pessoa.Nome, DbType.String);
                    parameters.Add("@CPF_PESSOA", pessoa.CPFPessoa, DbType.String);
                    parameters.Add("@FLAG_ATIVO_PESSOA", pessoa.FlagAtivoPessoa, DbType.Boolean);
                    parameters.Add("@DATA_CADASTRO_PESSOA", pessoa.DataCadastroPessoa, DbType.DateTime);

                    string sql = @"
                                INSERT INTO PESSOA
                                (
                                        NOME_PESSOA
                                        ,CPF_PESSOA
                                        ,FLAG_ATIVO_PESSOA
                                        ,DATA_CADASTRO_PESSOA
                                )
                                VALUES
                                (
                                        @NOME_PESSOA,
                                        @CPF_PESSOA,
                                        @FLAG_ATIVO_PESSOA
                                        @DATA_CADASTRO_PESSOA
                                );
                        
                            SELECT SCOPE_IDENTITY();
                    ";

                    return con.Query<int>(sql, param: parameters, commandType: CommandType.Text).FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                // Log
            }
            return 0;
        }

        public bool UpdatePessoa(TBLPessoa pessoa)
        {
            try
            {
                using (var con = dbConnection)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@ID_PESSOA", pessoa.IdPessoa, DbType.Int32);
                    parameters.Add("@NOME_PESSOA", pessoa.Nome, DbType.String);
                    parameters.Add("@CPF_PESSOA", pessoa.CPFPessoa, DbType.String);
                    parameters.Add("@FLAG_ATIVO_PESSOA", pessoa.FlagAtivoPessoa, DbType.Boolean);
                    parameters.Add("@DATA_CADASTRO_PESSOA", pessoa.DataCadastroPessoa, DbType.DateTime);

                    string sql = @"
                                UPDATE PESSOA 
                                SET     NOME_PESSOA           = @NOME_PESSOA,
                                        CPF_PESSOA            = @CPF_PESSOA,
                                        FLAG_ATIVO_PESSOA     = @FLAG_ATIVO_PESSOA
                                        DATA_CADASTRO_PESSOA  = @DATA_CADASTRO_PESSOA
                               WHERE ID_PESSOA = @ID_PESSOA
                    ";

                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }
    }
}
