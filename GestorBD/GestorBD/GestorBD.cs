﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.Data;

//===================================================================================================================
//  Classe criada para realizar a gestão de todo o banco de dados
//===================================================================================================================


namespace GestorBD
{
    //===============================================================================================================

    public class GestorBD
    {
        private SqlCeConnection connection;
        private SqlCeDataAdapter adapter;
        private SqlCeCommand command;

        private string connectionString = "";
        private string passwordDataBase = "123456";

        //===========================================================================================================

        public GestorBD()
        {

        }

        //===========================================================================================================

        public GestorBD(string nameDataBase)
        {
            try
            {
                StringBuilder str = new StringBuilder();

                str.Append("Data source = ");

                str.Append(nameDataBase);

                if (passwordDataBase != "")
                {
                    str.Append($"; Password = {passwordDataBase} ");
                }

                connectionString = str.ToString();

                connection = new SqlCeConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //===========================================================================================================

        public void CriarBaseDados(string dataBase, List<string> parametros, bool verificarExistenciaArquivo = false)
        {
            try
            {
                #region CRIACAO DO ARQUIVO DA BASE DE DADOS

                #region VERIFICA SE A BASE DE DADOS JÁ EXISTE

                StringBuilder str = new StringBuilder();

                str.Append("Data source = ");

                str.Append(dataBase);

                if (passwordDataBase != "")
                {
                    str.Append($"; Password = {passwordDataBase} ");
                }

                connectionString = str.ToString();

                if (verificarExistenciaArquivo == true)
                {
                    if (File.Exists(dataBase) == true)
                    {
                        if (MessageBox.Show("Já existe uma base de dados no caminho informado com esse nome, deseja substituí-lá?"
                                            , "ATENÇÃO"
                                            , MessageBoxButtons.YesNo
                                            , MessageBoxIcon.Question) == DialogResult.No)
                            return;
                        {
                            File.Delete(dataBase);
                        }
                    }
                }

                #endregion

                SqlCeEngine engine = new SqlCeEngine(connectionString);
                engine.CreateDatabase();
                engine.Dispose();
                #endregion

                #region CRIAÇÃO DAS TABELAS
                //-----------------------------------------------------------------------------
                // Realiza a criação das tabelas na base de dados.
                //-----------------------------------------------------------------------------

                connection = new SqlCeConnection(connectionString);
                connection.Open();
                command = new SqlCeCommand();
                command.Connection = connection;

                str.Clear();

                foreach (var item in parametros)
                {
                    if (item.StartsWith("CREATE TABLE"))
                    {
                        str = new StringBuilder();
                        str.Append(item);
                    }
                    else if (item == "FIM")
                    {
                        command.CommandText = str.ToString();
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        str.Append(item);
                    }
                }
                command.Dispose();
                connection.Dispose();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Base de dados criada com sucesso!");
        }

        //===========================================================================================================

        public DataTable Buscar(string query)
        {
            DataTable dataTable = new DataTable();
            adapter = new SqlCeDataAdapter(query, connection);

            try
            {
                adapter.Fill(dataTable);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            adapter.Dispose();
            return dataTable;
        }

        //===========================================================================================================






    }
}
