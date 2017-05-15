import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class MySQLConnection {

	Connection conn;
	Statement st;
	ResultSet result; 
	
	public MySQLConnection() {
		try{
			Class.forName("com.mysql.jdbc.Driver");
			String url = "jdbc:mysql://localhost:3306/historicaldata";
			conn = DriverManager.getConnection(url, "root", "");
			st = conn.createStatement();
			System.out.println("MySQL database connection established");
			
		}
		catch (Exception e) {
			System.err.println("Cannot connect to MySQL database server"); 
            System.err.println(e.getMessage());
		}
	}
	
	public void getData(){
		try{
			String query = "SELECT * FROM `public.data`";
			result = st.executeQuery(query);
			while(result.next()){
				String open = result.getString("open");
				System.out.println(open);
			}
		}
		catch (Exception e) {
			System.err.println("Cannot retrieve data from MySQL database");
			System.err.println(e.getMessage());
		}
	}
	
	public void insertData(){
		try{
			String query = "INSERT INTO `public.data` (`date`,`open`,`high`,`low`,`close`,`volume`,`adjclose`,`symbol`) "
					+ " VALUES (CURDATE(),'3.45','3.5','3.2','3.4','3.7','3000000','')";
			st.executeUpdate(query);
			System.out.println("Data has been inserted");
		}
		catch (Exception e) {
			System.out.println("Cannot insert data into database");
			System.out.println(e.getMessage());
		}
	}
	
	public void closeConnection(){
		if (conn != null) {
          try {
              conn.close();
              System.out.println("MySQL database connection terminated");
          } 
          catch (Exception e) {
          	System.out.println(e.getMessage());
          }
		}
	}
}
