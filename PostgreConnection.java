import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class PostgreConnection {
	Connection conn;
	Statement st;
	ResultSet result; 
	public PostgreConnection(){
		try{
			Class.forName("org.postgresql.Driver");
			String url = "";
			conn = DriverManager.getConnection(url, "root", "");
			st = conn.createStatement();
			System.out.println("PostgreSQL database connection established");
			
		}
		catch (Exception e) {
			System.err.println("Cannot connect to PostgreSQL database server"); 
            System.err.println(e.getMessage());
		}
	}
	
	public void getData(){
		
	}
	public void insertData(){
		
	}
	public void closeConnection(){
		if (conn != null) {
          try {
              conn.close();
              System.out.println("PostgreSQL database connection terminated");
          } 
          catch (Exception e) {
          	System.out.println(e.getMessage());
          }
		}
	}
}
