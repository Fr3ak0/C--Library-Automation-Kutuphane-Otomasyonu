using System;
using System.Data.SqlClient;

public class NotificationManager
{
    private SqlConnection connection;

    public NotificationManager(SqlConnection connection)
    {
        this.connection = connection;
    }

    public void CheckDueDateAndCreateNotifications()
    {
        // Tarihi geçmiş kitapları sorgula
        using (SqlCommand command = new SqlCommand("SELECT * FROM Tbl_GivenBooksStudent1 WHERE Date_Of_Back < @CurrentDate", connection))
        {
            command.Parameters.AddWithValue("@CurrentDate", DateTime.Now.Date);

            using (SqlDataReader reader1 = command.ExecuteReader())
            {
                while (reader1.Read())
                {
                    string studentNumber = reader1.GetString(5);
                    string studentMail = reader1.GetString(6);
                    DateTime notificationDate = DateTime.Now.Date;
                    int bookid = reader1.GetInt16(0);

                    // Bildirim oluştur
                    CreateNotification(studentNumber, studentMail, notificationDate, bookid);
                }
                reader1.Close();
            }
        }
    }

    private void CreateNotification(string studentNumber, string studentMail, DateTime notificationDate, int bookid)
    {
        using (SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Tbl_Notifications WHERE StudentNumber = @StudentNumber AND Book_Id = @Book_Id", connection))
        {
            checkCommand.Parameters.AddWithValue("@StudentNumber", studentNumber);
            checkCommand.Parameters.AddWithValue("@Book_Id", bookid);

            using (SqlDataReader checkReader = checkCommand.ExecuteReader())
            {
                if (checkReader.HasRows)
                {
                    checkReader.Close(); // SqlDataReader'ı kapat

                    int existingCount = (int)checkCommand.ExecuteScalar();

                    if (existingCount == 0)
                    {
                        using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Tbl_Notifications (Message, StudentNumber, StudentMail, Notification_date, Book_Id) VALUES (@Message, @StudentNumber, @StudentMail, @NotificationDate, @Book_Id)", connection))
                        {
                            insertCommand.Parameters.AddWithValue("@Message", "Geri dönüş tarihi geçti, lütfen kitabı iade edin.");
                            insertCommand.Parameters.AddWithValue("@StudentNumber", studentNumber);
                            insertCommand.Parameters.AddWithValue("@StudentMail", studentMail);
                            insertCommand.Parameters.AddWithValue("@NotificationDate", notificationDate);
                            insertCommand.Parameters.AddWithValue("@Book_Id", bookid);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    checkReader.Close(); // SqlDataReader'ı kapat
                }
            }
        }
    }
}