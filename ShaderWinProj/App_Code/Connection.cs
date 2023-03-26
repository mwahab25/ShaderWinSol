using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;
using System.Data;
using System.Collections;
using System.Reflection;

namespace ShaderWinProj.App_Code
{
    public class Connection
    {  
        public SqlConnection Cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Shader"].ConnectionString);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public DataSet Select(string sql, string Table)
        {

            if (Cn.State != ConnectionState.Open)
            {
                Cn.Open();
            }
            //ds.Clear() ; 
            da = new SqlDataAdapter(sql, Cn);
            da.Fill(ds, Table);

            Cn.Close();

            return ds;
        }
        
        public DataTable SelectProc(string proname, string[] colums, params object[] values)
        {
            SqlCommand Com = new SqlCommand();


            if (Cn.State != ConnectionState.Open)
            {
                Cn.Open();
            }
            Com.Connection = Cn;
            Com.CommandType = CommandType.StoredProcedure;
            Com.CommandText = proname;
            if (values != null)
            {
                for (int i = 0; i < values.Count(); i++)
                {
                    Com.Parameters.AddWithValue("@" + colums[i],values[i]);
                }
            }
            SqlDataAdapter da1 = new SqlDataAdapter(Com);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            Cn.Close();
            return dt1;
        }
       
        public void Excute(string sql)
        {

            if (Cn.State != ConnectionState.Open)
            {
                Cn.Open();
            }
            SqlCommand Run = new SqlCommand(sql, Cn);
            SqlTransaction tr;
            tr = Cn.BeginTransaction();
            Run.Transaction = tr;
            Run.CommandTimeout = 0;
            try
            {
                Run.ExecuteNonQuery();
                tr.Commit();
            }
            catch
            {
                //int o = 8;
                tr.Rollback();
            }
            Cn.Close();
        }

        public void ExcuteProc(string procname, string[] colums, params object[] values)
        {
            SqlCommand Com = new SqlCommand();


            if (Cn.State != ConnectionState.Open)
            {
                Cn.Open();
            }


            Com.Connection = Cn;
            Com.CommandType = CommandType.StoredProcedure;


            Com.CommandText = procname;
            if (values != null)
            {
                for (int i = 0; i < values.Count(); i++)
                {
                    Com.Parameters.AddWithValue("@" + colums[i], values[i]);
                }
            }
            Com.CommandTimeout = 0;
            Com.ExecuteNonQuery();
            Cn.InfoMessage += new SqlInfoMessageEventHandler(connection_InfoMessage);
            Cn.Close();

        }

        static void connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            // e contains info message etc

            if (e.Message.ToString() == "Sucess")
            {

            }
        }

        private void AddItem(IList list, Type type, string valueMember, string displayMember, string displayText)
        {
            //Creates an instance of the specified type using the constructor that best matches the specified parameters.
            Object obj = Activator.CreateInstance(type);

            // Gets the Display Property Information
            PropertyInfo displayProperty = type.GetProperty(displayMember);

            // Sets the required text into the display property
            displayProperty.SetValue(obj, displayText, null);

            // Gets the Value Property Information
            PropertyInfo valueProperty = type.GetProperty(valueMember);

            // Sets the required value into the value property
            valueProperty.SetValue(obj, -1, null);

            // Insert the new object on the list
            list.Insert(0, obj);
        }
    }
}
