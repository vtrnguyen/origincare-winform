using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Bookingcare_Winform
{
    internal class Database
    {
        private string serverName;
        private string databaseName;
        private string connectionString;

        public Database()
        {
            this.serverName = "LAPTOP-BCBLAOBU\\SQLEXPRESS";
            this.databaseName = "BookingCare";
            this.connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True";
        }

        public bool connect()
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }

        // TABLE USERS
        public (string userID, string userLastName, string roleID) handleLogin(string userName, string password)
        {
            string query = "select id, lastName, roleID from Users" +
                " where email = @userName and password = @password";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string userId = reader["id"].ToString();
                                string userLastName = reader["lastName"].ToString();
                                string roleID = reader["roleID"].ToString();

                                return (userId, userLastName, roleID);
                            }
                            else
                            {
                                return (null, null, null);
                            }
                        }
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);

                    return (null, null, null);
                }
            }
        }

        public DataTable getAllUser()
        {
            string query = "SELECT \r\n    " +
                    "u.id,\r\n    " +
                    "u.email,\r\n    " +
                    "u.password,\r\n    " +
                    "u.firstName,\r\n    " +
                    "u.lastName,\r\n    " +
                    "u.address,\r\n    " +
                    "g.codeValue AS gender,\r\n    " +
                    "r.codeValue AS role,\r\n    " +
                    "p.codeValue AS position,\r\n    " +
                    "u.phoneNumber\r\nFROM \r\n    " +
                "Users u\r\n" +
                "LEFT JOIN \r\n    AllCodes g " +
                "ON " +
                    "u.gender = g.keyMap AND " +
                    "g.codeType = 'GENDER'\r\n" +
                "LEFT JOIN \r\n    AllCodes r " +
                "ON " +
                    "u.roleID = r.keyMap AND " +
                    "r.codeType = 'ROLE'\r\n" +
                "LEFT JOIN \r\n    AllCodes p " +
                "ON " +
                    "u.positionID = p.keyMap AND " +
                    "p.codeType = 'POSITION'";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable users = new DataTable();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader userData = command.ExecuteReader())
                        {
                            users.Load(userData);
                        }
                    }

                    return users;
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public DataTable getUser(string userID)
        {
            string query = "select email, password, firstName, lastName, address, phoneNumber" +
                " from Users where id = @userID";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable users = new DataTable();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);

                        using (SqlDataReader userData =  command.ExecuteReader())
                        {
                            users.Load(userData);
                        }
                    }

                    return users;
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public DataTable getDoctorUserForDoctorComboBox()
        {
            string query = "select id, firstName + ' ' + lastName as fullName" +
                " from Users" +
                " where roleID = 'R1'";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable doctors = new DataTable();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader doctorData = command.ExecuteReader())
                        {
                            doctors.Load(doctorData);
                        }
                    }

                    return doctors;
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public DataTable getComboBoxData(string codeType)
        {
            string query = "select keyMap, codeValue from AllCodes" +
                " where codeType=@codeType";

            using (SqlConnection connection =new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable cboData = new DataTable();

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@codeType", codeType);

                        using(SqlDataReader data = command.ExecuteReader())
                        {
                            cboData.Load(data);
                        }
                    }

                    return cboData;
                } catch(Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public bool createUser(string email, string password, string firstName, string lastName, 
            string address, string phoneNumber, string gender, string roleID, string positionID)
        {
            string query = "insert into Users" +
                " (email, password, firstName, lastName, address, gender, roleID, phoneNumber, positionID)" +
                " values(@email, @password, @firstName, @lastName, @address, @gender, @roleID, @phoneNumber, @positionID)";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@roleID", roleID);
                        command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@positionID", positionID);

                        int rowsEffect = command.ExecuteNonQuery();

                        return (rowsEffect > 0);
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }

        public bool updateUser(string email, string password, string firstName, string lastName,
            string address, string phoneNumber, string gender, string roleID, string positionID)
        {
            string query = "update Users" +
                " set password = @password, firstName = @firstName, lastName = @lastName," +
                " address = @address, phoneNumber = @phoneNumber, gender = @gender, roleID = @roleID, positionID = @positionID" +
                " where email = @email";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@roleID", roleID);
                        command.Parameters.AddWithValue("@positionID", positionID);

                        int rowsEffected = command.ExecuteNonQuery();

                        return (rowsEffected > 0);
                    }
                } catch (Exception ex) {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }

        public bool deleteUser(string userID)
        {
            string query = "delete from Users where id = @userID";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);

                        int rowsAffected = command.ExecuteNonQuery();

                        return (rowsAffected > 0);
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }

        public int isExistedEmail(string email)
        {
            string query = "select count(*) from Users where email=@email";

            using (SqlConnection connection = new SqlConnection (this.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand (query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);

                        object numberOfEmail = command.ExecuteScalar();
                        return (numberOfEmail != null) ? Convert.ToInt32(numberOfEmail) : 0;
                    }
                } catch(Exception ex) 
                {
                    Console.WriteLine("Lỗi" + ex.Message);
                    return 0;
                }
            }
        }

        // TABLE CLINICS
        public DataTable getAllClinic()
        {
            string query = "select * from Clinics";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable clinics = new DataTable();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader clinicData = command.ExecuteReader())
                        {
                            clinics.Load(clinicData);
                        }
                    }

                    return clinics;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public DataTable getClinicInfor(string clinicID)
        {
            string query = "select * from Clinics where id = @clinicID";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable clinicInfor = new DataTable();
                    
                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@clinicID", clinicID);

                        using (SqlDataReader clinicData = command.ExecuteReader())
                        {
                            clinicInfor.Load(clinicData);
                        }
                    }

                    return clinicInfor;
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    
                    return null;
                }
            }
        }

        public DataTable getClinicForClinicComboBox()
        {
            string query = "select id, clinicName" +
                " from Clinics";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable clinics = new DataTable();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader clinicData = command.ExecuteReader())
                        {
                            clinics.Load(clinicData);
                        }
                    }

                    return clinics;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public bool createClinic(string clinicName, string clinicAddress, string clinicDescription, byte[] clinicImage)
        {
            string query = "insert into Clinics (clinicName, address, description, image)" +
                " values (@clinicName, @clinicAddress, @clinicDescription, @clinicImage)";

            using (SqlConnection connection = new SqlConnection (this.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@clinicName", clinicName);
                        command.Parameters.AddWithValue("@clinicAddress", clinicAddress);
                        command.Parameters.AddWithValue("@clinicDescription", clinicDescription);
                        command.Parameters.AddWithValue("@clinicImage", clinicImage);

                        int rowsEffected = command.ExecuteNonQuery();

                        return (rowsEffected > 0);
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }

        public bool deleteClinic(string clinicID)
        {
            string query = "delete from Clinics where id = @clinicID";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@clinicID", clinicID);

                        int rowsEffected = command.ExecuteNonQuery();

                        return (rowsEffected > 0);
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public bool updateClinic(string clinicID, string clinicName, string clinicAddress, string clinicDescription, byte[] clinicImage)
        {
            string query = "update Clinics" +
                " set clinicName = @clinicName, address = @clinicAddress," +
                " description = @clinicDescription, image = @clinicImage" +
                " where id = @clinicID";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@clinicID", clinicID);
                        command.Parameters.AddWithValue("@clinicName", clinicName);
                        command.Parameters.AddWithValue("@clinicAddress", clinicAddress);
                        command.Parameters.AddWithValue("@clinicDescription", clinicDescription);
                        command.Parameters.AddWithValue("@clinicImage", clinicImage);

                        int rowsEffected = command.ExecuteNonQuery();

                        return (rowsEffected > 0);
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }
    
        // TABLE SPECIALTIES
        public DataTable getAllSpecialty()
        {
            string query = "select id, specialtyName, description, image from Specialties";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable specialties = new DataTable();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        using (SqlDataReader specialtyData = command.ExecuteReader())
                        {
                            specialties.Load(specialtyData);
                        }

                        return specialties;
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public DataTable getSpecialtyInfor(string specialtyID)
        {
            string query = "select description, specialtyName, image" +
                " from Specialties" +
                " where id = @specialtyID";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable specialtyInfor = new DataTable();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@specialtyID", specialtyID);

                        using (SqlDataReader specialtyData = command.ExecuteReader())
                        {
                            specialtyInfor.Load(specialtyData);
                        }
                    }

                    return specialtyInfor;
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public DataTable getSpecialtyForSpecialtyComboBox()
        {
            string query = "select id, specialtyName" +
                " from Specialties";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable specialties = new DataTable();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader specialtyData = command.ExecuteReader())
                        {
                            specialties.Load(specialtyData);
                        }
                    }

                    return specialties;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public bool createSpecialty(string specialtyName, string specialtyDescription, byte[] specialtyImage)
        {
            string query = "insert into Specialties (specialtyName, description, image)" +
                " values (@specialtyName, @specialtyDescription, @specialtyImage)";

            using (SqlConnection connection = new SqlConnection (this.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@specialtyName", specialtyName);
                        command.Parameters.AddWithValue("@specialtyDescription", specialtyDescription);
                        command.Parameters.AddWithValue("@specialtyImage", specialtyImage);

                        int rowsEffected = command.ExecuteNonQuery();

                        return (rowsEffected > 0);
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }

        public bool updateSpecialty(string specialtyID, string specialtyName, string specialtyDescription, byte[] specialtyImage)
        {
            string query = "update Specialties" +
                " set specialtyName = @specialtyName, description = @specialtyDescription, image = @specialtyImage" +
                " where id = @specialtyID";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand (query, connection))
                    {
                        command.Parameters.AddWithValue("@specialtyID", specialtyID);
                        command.Parameters.AddWithValue("@specialtyName", specialtyName);
                        command.Parameters.AddWithValue("@specialtyDescription", specialtyDescription);
                        command.Parameters.AddWithValue("@specialtyImage", specialtyImage);

                        int rowsEffected = command.ExecuteNonQuery();

                        return (rowsEffected > 0);
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }
    
        public bool deleteSpecialty(string specialtyID)
        {
            string query = "delete from Specialties" +
                " where id = @specialtyID";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@specialtyID", specialtyID);

                        int rowsEffected = command.ExecuteNonQuery();

                        return (rowsEffected > 0);
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }

        // TABLE DOCTOR INFORS
        public DataTable getAllDoctorInfor()
        {
            string query = @"SELECT
                           DI.doctorID,
                           U.firstName + ' ' + U.lastName AS fullName, 
                           S.specialtyName AS specialtyName, 
                           C.clinicName AS clinicName,  
                           AC_Price.codeValue AS priceName, 
                           AC_Payment.codeValue AS paymentName, 
                           AC_Province.codeValue AS provinceName, 
                           DI.description, 
                           AC_Position.codeValue AS positionName,
                           DI.image
                    FROM DoctorInfors DI
                    JOIN Users U ON DI.doctorID = U.id
                    JOIN Specialties S ON DI.specialtyID = S.id
                    JOIN Clinics C ON DI.clinicID = C.id
                    JOIN AllCodes AC_Price ON DI.priceID = AC_Price.keyMap
                    JOIN AllCodes AC_Payment ON DI.paymentID = AC_Payment.keyMap
                    JOIN AllCodes AC_Province ON DI.provinceID = AC_Province.keyMap
                    JOIN AllCodes AC_Position ON U.positionID = AC_Position.keyMap";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable doctorInfors = new DataTable();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader doctorInforTable = command.ExecuteReader())
                        {
                            doctorInfors.Load(doctorInforTable);
                        }
                    }
                    
                    return doctorInfors;
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public DataTable getDoctorInfor(string doctorID)
        {
            string query = "SELECT U.firstName + ' ' + U.lastName AS fullName, S.specialtyName AS specialtyName, " +
                "C.clinicName AS clinicName,  AC_Price.codeValue AS priceName, AC_Payment.codeValue AS paymentName, " +
                "AC_Province.codeValue AS provinceName, DI.description, DI.image " +
                "FROM DoctorInfors DI " +
                "JOIN Users U ON DI.doctorID = U.id " +
                "JOIN Specialties S ON DI.specialtyID = S.id " +
                "JOIN Clinics C ON DI.clinicID = C.id " +
                "JOIN AllCodes AC_Price ON DI.priceID = AC_Price.keyMap " +
                "JOIN AllCodes AC_Payment ON DI.paymentID = AC_Payment.keyMap " +
                "JOIN AllCodes AC_Province ON DI.provinceID = AC_Province.keyMap " +
                "WHERE U.id = @doctorID";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable doctorInfor = new DataTable();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@doctorID", doctorID);

                        using (SqlDataReader doctorInforTable = command.ExecuteReader())
                        {
                            doctorInfor.Load(doctorInforTable);
                        }
                    }

                    return doctorInfor;
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public DataTable getDetailInforDoctor(string doctorID)
        {
            string query = @"select 
	                            U.firstName + ' ' + U.lastName as 'doctorName', S.specialtyName, C.clinicName, DI.description, APAY.codeValue as 'paymentName',
	                            APRO.codeValue as 'provinceName', APRI.codeValue as 'price', U.address, APOS.codeValue as 'positionName', DI.image as 'doctorImage'
                            from DoctorInfors DI
                            join Users U
                            on DI.doctorID = U.id
                            join Clinics C
                            on DI.clinicID = C.id
                            join Specialties S
                            on DI.specialtyID = S.id
                            join AllCodes APRO
                            on DI.provinceID = APRO.keyMap
                            join AllCodes APRI
                            on DI.priceID = APRI.keyMap
                            join AllCodes APAY
                            on DI.paymentID = APAY.keyMap
                            join AllCodes APOS
                            on U.positionID = APOS.keyMap
                            where DI.doctorID = @doctorID";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable doctorInfor = new DataTable();

                    using (SqlCommand command = new SqlCommand (query, connection))
                    {
                        command.Parameters.AddWithValue("@doctorID", doctorID);

                        using (SqlDataReader doctorData =  command.ExecuteReader())
                        {
                            doctorInfor.Load(doctorData);
                        }
                    }

                    return doctorInfor;
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
         
                    return null;
                }
            }
        }

        public DataTable getInforDoctorForDetailSpecialty(string specialtyID, string provinceID)
        {
            string query = "";

            if (provinceID == "ALL")
            {
                query = @"select 
	                            DI.doctorID, U.firstName + ' ' + U.lastName as 'doctorName', S.specialtyName, C.clinicName,
	                            U.address, APOS.codeValue as 'positionName', DI.image as 'doctorImage', DI.description
                            from DoctorInfors DI
                            join Users U
                            on DI.doctorID = U.id
                            join Clinics C
                            on DI.clinicID = C.id
                            join Specialties S
                            on DI.specialtyID = S.id
                            join AllCodes APOS
                            on U.positionID = APOS.keyMap
                            where S.id = @specialtyID";
            } else
            {
                query = @"select 
	                            DI.doctorID, U.firstName + ' ' + U.lastName as 'doctorName', S.specialtyName, C.clinicName,
	                            U.address, APOS.codeValue as 'positionName', DI.image as 'doctorImage', DI.description
                            from DoctorInfors DI
                            join Users U
                            on DI.doctorID = U.id
                            join Clinics C
                            on DI.clinicID = C.id
                            join Specialties S
                            on DI.specialtyID = S.id
                            join AllCodes APOS
                            on U.positionID = APOS.keyMap
                            where S.id = @specialtyID and DI.provinceID = @provinceID";
            }

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable doctorInfor = new DataTable();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@specialtyID", specialtyID);

                        if (provinceID != "ALL")
                        {
                            command.Parameters.AddWithValue("@provinceID", provinceID);
                        }

                        using (SqlDataReader doctorData = command.ExecuteReader())
                        {
                            doctorInfor.Load(doctorData);
                        }
                    }

                    return doctorInfor;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public DataTable getInforDoctorForDetailClinic(string clinicID)
        {
            string query = @"select 
		                        DI.doctorID, U.firstName + ' ' + U.lastName as 'doctorName', S.specialtyName, C.clinicName,
		                        U.address, APOS.codeValue as 'positionName', DI.image as 'doctorImage', DI.description
	                        from DoctorInfors DI
                            join Users U
                            on DI.doctorID = U.id
	                        join Clinics C
                            on DI.clinicID = C.id
                            join Specialties S
                            on DI.specialtyID = S.id
                            join AllCodes APOS
                            on U.positionID = APOS.keyMap
                            where C.id = @clinicID";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable doctorInfors = new DataTable();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@clinicID", clinicID);

                        using (SqlDataReader doctorData = command.ExecuteReader())
                        {
                            doctorInfors.Load(doctorData);
                        }
                    }

                    return doctorInfors;
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public bool createDoctorInfor(string doctorID, string specialtyID, string clinicID, string priceID,
             string provinceID, string paymentID, string description, byte[] image)
        {
            string query = "insert into DoctorInfors" +
                " (doctorID, specialtyID, clinicID, priceID, provinceID, paymentID, description, image)" +
                " values (@doctorID, @specialtyID, @clinicID, @priceID, @provinceID, @paymentID, @description, @image)";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@doctorID", doctorID);
                        command.Parameters.AddWithValue("@specialtyID", specialtyID);
                        command.Parameters.AddWithValue("@clinicID", clinicID);
                        command.Parameters.AddWithValue("@priceID", priceID);
                        command.Parameters.AddWithValue("@provinceID", provinceID);
                        command.Parameters.AddWithValue("@paymentID", paymentID);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@image", image);

                        int rowsEffected = command.ExecuteNonQuery();

                        return (rowsEffected > 0);
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }

        public bool updateDoctorInfor(string doctorID, string specialtyID, string clinicID, string priceID,
             string provinceID, string paymentID, string description, byte[] image)
        {
            string query = "update DoctorInfors" +
                " set specialtyID = @specialtyID, clinicID = @clinicID, priceID = @priceID," +
                " provinceID = @provinceID, paymentID = @paymentID, description = @description, image = @image" +
                " where doctorID = @doctorID";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@doctorID", doctorID);
                        command.Parameters.AddWithValue("@specialtyID", specialtyID);
                        command.Parameters.AddWithValue("@clinicID", clinicID);
                        command.Parameters.AddWithValue("@priceID", priceID);
                        command.Parameters.AddWithValue("@provinceID", provinceID);
                        command.Parameters.AddWithValue("@paymentID", paymentID);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@image", image);

                        int rowsEffected = command.ExecuteNonQuery();

                        return (rowsEffected > 0);
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }

        // TABLE SCHEDULES
        public DataTable getAllBookingTime()
        {
            string query = "select keyMap, codeValue" +
                " from AllCodes" +
                " where codeType = 'TIME'";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable bookingTimes = new DataTable();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader bookingTimeData = command.ExecuteReader())
                        {
                            bookingTimes.Load(bookingTimeData);
                        }
                    }

                    return bookingTimes;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public bool bulkCreateDoctorSchedule(string doctorID, DateTime bookingDate, List<string> timeBookings)
        {
            string query = @"
                if not exists (select 1 
                               from Schedules 
                               where doctorID = @doctorID 
                               and bookingDate = @bookingDate 
                               and timeType = @timeType)
                begin
                    insert into Schedules (doctorID, bookingDate, timeType) 
                    values (@doctorID, @bookingDate, @timeType)
                end";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            foreach (var timeType in timeBookings)
                            {
                                using (SqlCommand cmd = new SqlCommand(query, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@doctorID", doctorID);
                                    cmd.Parameters.AddWithValue("@bookingDate", bookingDate);
                                    cmd.Parameters.AddWithValue("@timeType", timeType);

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();

                            return true;
                        } catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine("Lỗi: " + ex.Message);

                            return false;
                        }
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable getAllBookingSchedule(string doctorID, DateTime bookingDate)
        {
            string query = "select S.timeType, A.codeValue" +
                            " from Schedules S" +
                            " join AllCodes A" +
                            " on S.timeType = A.keyMap" +
                            " where doctorID = @doctorID and bookingDate = @bookingDate";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable bookingTimes = new DataTable();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@doctorID", doctorID);
                        command.Parameters.AddWithValue("@bookingDate", bookingDate);

                        using (SqlDataReader bookingTimeData = command.ExecuteReader())
                        {
                            bookingTimes.Load(bookingTimeData);
                        }
                    }

                    return bookingTimes;
                } catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        // TABLE BOOKINGS
        public bool createBookingSchedule(string doctorID, string patientEmail, DateTime bookingDate, string bookingTime)
        {
            string query = @"
                        if not exists (select 1
                                       from Bookings
                                       where doctorID = @doctorID
                                       and patientEmail = @patientEmail
                                       and bookingDate = @bookingDate
                                       and timeType = @bookingTime)
                        begin
                            insert into Bookings (doctorID, patientEmail, bookingDate, timeType)
                            values (@doctorID, @patientEmail, @bookingDate, @bookingTime)
                        end";

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@doctorID", doctorID);
                        command.Parameters.AddWithValue("@patientEmail", patientEmail);
                        command.Parameters.AddWithValue("@bookingDate", bookingDate);
                        command.Parameters.AddWithValue("@bookingTime", bookingTime);

                        int rowsEffected = command.ExecuteNonQuery();

                        return (rowsEffected > 0);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
