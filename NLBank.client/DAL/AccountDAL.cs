﻿using NLBank.client.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DAL
{
    public class AccountDAL
    {
        public static int login(string email, string password)
        {
            Console.WriteLine(email);   
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand($"select dbo.f_login_getRoleID('{email}', '{password}') ", Conn);

            Conn.Open();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var data = reader.GetInt32(0);
                    return data;
                }
            }
            Conn.Close();
            return -1;

        }
        public static KHDTO GetKhachHangByEmail(string email)
        {
            KHDTO khdto = new KHDTO();
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand($"select * from f_GetKHByEmail('{email}') ", Conn);

            Conn.Open();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    khdto.Dia_chi = reader["Dia_chi"].ToString(); 
                    khdto.Email = reader["Email"].ToString(); 
                    khdto.Ten = reader["Ten"].ToString(); 
                    khdto.Sdt = reader["Sdt"].ToString();
                    khdto.RoleID = Int32.Parse(reader["RoleID"].ToString());  
                   khdto.MaKH = Int32.Parse(reader["MaKH"].ToString());
                }
            }
            
            Conn.Close();
            return khdto; 

        }

        public static NhanvienDTO GetNhanVienByEmail(string email)
        {
            NhanvienDTO nv = new NhanvienDTO();
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand($" select * from f_GetNVByEmail('{email}') ", Conn);

            Conn.Open();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    nv.Dia_chi = reader["Dia_chi"].ToString();
                    nv.Email = reader["Email"].ToString();
                    nv.Ten = reader["Ten"].ToString();
                    nv.Sdt = reader["Sdt"].ToString();
                    nv.MaCV = Int32.Parse(reader["MaCV"].ToString());
                    nv.CCCD = reader["CCCD"].ToString(); 
                }
            }

            Conn.Close();
            return nv;

        }
    }
}
