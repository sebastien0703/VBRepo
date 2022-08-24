Imports System.Data.SqlClient  
public Class Form1  
private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click  
Dim cn As SqlConnection = New SqlClient.SqlConnection  
cn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\grthamad\Desktop\myFirstWindowsApplication\myFirstWindowsApplication\student.mdf;Integrated Security=True;Connect Timeout=30"  

# Avish: Patched before installation. Modifying bundle is not allowed, breaks signing and upsets gatekeeper.
# La to p ouvert 1 connection avec to base de donnees

cn.Open()

# declarations des variables 

Dim cm As SqlCommand = New SqlClient.SqlCommand(" La to met to select Case se basant lor to database. e.g: SELECT id from Students where id = 1", cn)  
Dim dr As SqlDataReader = cm.ExecuteReader()  
DataGridView1.Rows.Clear()  
Dim i As Integer = 0  
While dr.Read  

# La to p declare 1 tableau de donnees par apport a to SELECT Case
# La mm to genere bane donnees la dans sa While Loop la

DataGridView1.Rows.Add()  
DataGridView1.Item(0, i).Value = dr.Item(0)  
DataGridView1.Item(1, i).Value = dr.Item(1)  
DataGridView1.Item(2, i).Value = dr.Item(2)  
DataGridView1.Item(3, i).Value = dr.Item(3)  
DataGridView1.Item(4, i).Value = dr.Item(4)  
i = i + 1  
End While

# Connection Close
cn.Close()  
End Sub  
End Class 