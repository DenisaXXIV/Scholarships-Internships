package com.cts.academy.profiles.c3p0;

import com.cts.academy.profiles.App;
import com.mchange.v2.c3p0.ComboPooledDataSource;

import java.beans.PropertyVetoException;
import java.util.Properties;

public class ConnectionManager {
    private static ConnectionManager connectionManagerInstance = null;
    private static ComboPooledDataSource comboPooledDataSource =  null;

    private ConnectionManager()
    {
    }
    public static ConnectionManager getInstance()
    {
        if (connectionManagerInstance == null)
            connectionManagerInstance = new ConnectionManager();

        return connectionManagerInstance;
    }
    public static void deleteInstance()
    {
        if (connectionManagerInstance != null)
            connectionManagerInstance = null;

    }
    public ComboPooledDataSource getConnection() throws PropertyVetoException {
        if (connectionManagerInstance != null)
        {
            comboPooledDataSource = new ComboPooledDataSource();
            App app = new App();
            Properties prop = app.loadPropertiesFile("app.properties");
            comboPooledDataSource.setDriverClass( prop.getProperty("db.driverClassName") );
            comboPooledDataSource.setJdbcUrl( prop.getProperty("db.url") );
            comboPooledDataSource.setUser(prop.getProperty("db.username"));
            comboPooledDataSource.setPassword(prop.getProperty("db.password"));
        }
        return comboPooledDataSource;
    }

}
