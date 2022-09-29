package com.denisa.services;

import com.denisa.entities.Customer;
import com.denisa.exceptions.BankException;

import java.util.Random;

public class BankService {
    public boolean validateCustomer(Customer customer) throws BankException {
        if(customer.getAccountBalance() >= 0) {
            return true;
        }
        else throw new BankException("BankService err");
    }

    public double sendMoney(Customer customer, double sum) {
        Random random = new Random();

        double fees = random.nextDouble(1);

        return sum+fees;
    }
}
