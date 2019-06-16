using System;
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
        private SqlCeDataAdapter adapterTemp;
        private SqlCeCommand command;

        private string connectionString = "";
        private string passwordDataBase = "123456";

        //===========================================================================================================

        public class SQLParametro
        {
            public string ParameterName { get; set; }
            public object ParameterValue { get; set; }

            public SQLParametro(string ParameterName, object ParameterValue)
            {
                this.ParameterName = ParameterName;
                this.ParameterValue = ParameterValue;
            }


        }

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

        public DataTable Select(string query, List<SQLParametro> parametros = null)
        {
            DataTable dataTable = new DataTable();
            adapter = new SqlCeDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.Clear();

            try
            {
                if (parametros != null)
                {
                    foreach (var item in parametros)
                    {
                        adapter.SelectCommand.Parameters.AddWithValue(item.ParameterName,item.ParameterValue);
                    }
                }
                
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

        public void ExecuteNonQuery(string query, List<SQLParametro> parametros = null)
        {
            try
            {
                connection = new SqlCeConnection(connectionString);
                connection.Open();
                command = new SqlCeCommand(query, connection);
                command.Parameters.Clear();

                if (parametros != null)
                {
                    foreach (var item in parametros)
                    {
                        command.Parameters.AddWithValue(item.ParameterName, item.ParameterValue);
                    }
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            command.Dispose();
            connection.Dispose();
            MessageBox.Show("Query executada com sucesso!");
        }

        //===========================================================================================================

        public DataTable CriarTempTable(string query)
        {
            adapterTemp = new SqlCeDataAdapter(query, connection);
            DataTable dataTableTemp = new DataTable();

            try
            {
                adapterTemp.Fill(dataTableTemp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTableTemp;
        }

        //===========================================================================================================
        
        public void GravarTempTable(DataTable dataTableTemp)
        {
            //SqlCeDataAdapter adapter = adapterTemp;
            SqlCeCommandBuilder commandBuilder = new SqlCeCommandBuilder(adapterTemp);
            adapterTemp.UpdateCommand = commandBuilder.GetUpdateCommand();

            try
            {
                adapterTemp.Update(dataTableTemp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            adapterTemp.Dispose();

        }

        //===========================================================================================================

        public void CompactarBaseDados()
        {
            try
            {
                SqlCeEngine engine = new SqlCeEngine();
                engine.Compact(connectionString);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //===========================================================================================================
    }
}
