package com.denisa.entities;

import com.denisa.exceptions.RemoveCustomerException;
import com.denisa.exceptions.BankException;
import com.denisa.services.BankService;

import java.util.HashMap;
import java.util.UUID;

public class Bank {
    private String name;
    private HashMap<UUID,Customer> customerList;
    private BankService bankService;

    Bank(BankService bankService) {
        this.customerList = new HashMap<>();
        this.bankService = bankService;
    }

    public void addCustomer(Customer customer) {
            this.customerList.put(customer.getId(),customer);
    }

    public void removeCustomer(Customer customer) throws RemoveCustomerException {
        if(customer.getAccountBalance() >= 0) {
            this.customerList.remove(customer.getId());
        }
        else throw new RemoveCustomerException();
    }

    public boolean doTransfer(Customer customer,double sum) throws BankException {
        if(this.bankService.validateCustomer(customer)) {
            this.bankService.sendMoney(customer,sum);
            return true;
        }else throw new BankException(String.valueOf(customer.getAccountBalance()));


    }

    public HashMap<UUID,Customer> getCustomerList() {
        return customerList;
    }
}
