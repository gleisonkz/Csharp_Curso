using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

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
        private string passwordDataBase = "";

        //===========================================================================================================

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

                MessageBox.Show($"DataBase {nameDataBase.ToUpper()} status: {connection.State}");

                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //===========================================================================================================

        //===========================================================================================================

        public void CriarBaseDados(string nameDataBase, bool verificarExistenciaArquivo = false)
        {
            try
            {
                #region Verificar se a Base de Dados existe

                StringBuilder str = new StringBuilder();

                str.Append("Data source = ");

                str.Append(nameDataBase);

                if (passwordDataBase != "")
                {
                    str.Append($"; Password = {passwordDataBase} ");
                }

                connectionString = str.ToString();

                if (verificarExistenciaArquivo == true)
                {
                    if (File.Exists(nameDataBase) == true)
                    {
                        if (MessageBox.Show("Já existe uma base de dados no caminho informado com esse nome, deseja substituí-lá?"
                                            , "ATENÇÃO"
                                            , MessageBoxButtons.YesNo
                                            , MessageBoxIcon.Question) == DialogResult.No)
                            return;
                        {
                            File.Delete(nameDataBase);
                        }
                    }
                }

                #endregion

                SqlCeEngine engine = new SqlCeEngine(connectionString);
                engine.CreateDatabase();
                engine.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Base de dados criada com sucesso!");
        }

        //===========================================================================================================






    }
}
