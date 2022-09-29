import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) {
        Company company = new Company();
        String choice = new String();
        Logger logger = LoggerFactory.getLogger(Main.class);

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        System.out.println("Please enter your choice: ");
        System.out.println("(Sunday, Monday, ..., Saturday, All)");

        try {
            choice = reader.readLine();
        } catch (IOException e) {
            throw new RuntimeException(e);
        }

        switch(choice) {
            case "Monday":
                logger.info(company.getOccupancyByDay(2));
                break;
            case "Tuesday":
                logger.info(company.getOccupancyByDay(3));
                break;
            case "Wednesday":
                logger.info(company.getOccupancyByDay(4));
                break;
            case "Thursday":
                logger.info(company.getOccupancyByDay(5));
                break;
            case "Friday":
                logger.info(company.getOccupancyByDay(6));
                break;
            case "Saturday":
                logger.info(company.getOccupancyByDay(7));
                break;
            case "Sunday":
                logger.info(company.getOccupancyByDay(1));
                break;
            case "All":
                logger.info(company.toString());
                break;
        }
    }

}
