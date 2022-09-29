package com.denisa.entities;

import java.util.UUID;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Customer {
    private UUID id;
    private String name;
    private String address;
    private double accountBalance;

    public Customer(String name, String address) {
        if(validateCustomer(name, address)) {
            this.name = name;
            this.address = address;
            this.id = UUID.randomUUID();
            this.accountBalance = 0.0;
        }
    }

    public Customer(String name, String address, double accountBalance) {
        if(validateCustomer(name, address)) {
            this.name = name;
            this.address = address;
            this.id = UUID.randomUUID();
            this.accountBalance = accountBalance;
        }
    }

    public boolean validateCustomer(String name, String mail) {
        if(name.length() < 4) {
            try {
                throw new Exception("! Name must have at least 4 characters !");
            } catch (Exception e) {
                throw new RuntimeException(e);
            }
        }
        else {
            Pattern pattern = Pattern.compile("(^[a-zA-Z0-9_+&-]+(?:\\.[a-zA-Z0-9_+&-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,7}$)");
            Matcher matcher = pattern.matcher(mail);
            if(!matcher.find()) {
                try {
                    throw new Exception("! Email address must be a valid one !");
                } catch (Exception e) {
                    throw new RuntimeException(e);
                }
            }
        }

        return true;
    }

    public UUID getId() {
        return id;
    }

    public void setAccountBalance(double accountBalance) {
        this.accountBalance = accountBalance;
    }

    public double getAccountBalance() {
        return accountBalance;
    }
}
