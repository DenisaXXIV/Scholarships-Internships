import enums.Day;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.LinkedHashMap;
import java.util.Map;

public class Company {

    private int employees;
    private LinkedHashMap<Day,Integer> occupancy = new LinkedHashMap<>();

    public int getEmployees() {
        return employees;
    }

    public void setEmployees(int employees) {
        this.employees = employees;
    }

    Company() {
        readEmployees();
        setOccupancy();
    }

    public void readEmployees() {

        int employees = 0;

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        System.out.println("Hello!");
        System.out.println("Please enter the number of employees: ");

        try {
            employees = (int) Integer.parseInt(reader.readLine());
        } catch (IOException e) {
            throw new RuntimeException(e);
        } catch (NumberFormatException e) {
            readEmployees();
        }

        this.employees = employees;

    }

    public void setOccupancy() {
        this.occupancy.putIfAbsent(Day.Monday,(getRandomNumber(50,90)*this.employees)/100);
        this.occupancy.putIfAbsent(Day.Tuesday,(getRandomNumber(60,70)*this.employees)/100);
        this.occupancy.putIfAbsent(Day.Wednesday,(getRandomNumber(40,80)*this.employees)/100);
        this.occupancy.putIfAbsent(Day.Thursday,(getRandomNumber(50,60)*this.employees)/100);
        this.occupancy.putIfAbsent(Day.Friday,(getRandomNumber(30,50)*this.employees)/100);
        this.occupancy.putIfAbsent(Day.Saturday,(getRandomNumber(0,20)*this.employees)/100);
        this.occupancy.putIfAbsent(Day.Sunday,0);
    }

    public int getRandomNumber( int min, int max) {
        return (int) ((Math.random() * (max-min)) + min);
    }

    public String getOccupancyByDay(int day) {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.append("Currently there are "
                + Integer.toString(this.employees)
                + " employees in the company. \n" );

        stringBuilder.append("Day of the week: ").append(String.valueOf(day))
                .append(", Office Occupancy is: ").append(this.occupancy.get(Day.castIntToEnum(day)));

        return stringBuilder.toString();

    }

    @Override
    public String toString() {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.append("Currently there are "
                + Integer.toString(this.employees)
                + " employees in the company. \n" );

        for (Map.Entry<Day,Integer> entry : this.occupancy.entrySet() ) {
            stringBuilder.append(entry.getKey().toString()).append("(").append(entry.getKey().getValue()).append("): ");
            stringBuilder.append(entry.getValue().toString() + "\n");
        }


        return stringBuilder.toString();
    }
}
