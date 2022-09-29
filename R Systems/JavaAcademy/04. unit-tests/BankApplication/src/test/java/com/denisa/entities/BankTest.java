package com.denisa.entities;

import com.denisa.exceptions.BankException;
import com.denisa.exceptions.RemoveCustomerException;
import com.denisa.services.BankService;
import com.sun.source.tree.ModuleTree;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;
import org.mockito.Mockito;

public class BankTest {

    private Bank bank;
    private BankService bankService;

    @BeforeEach
    void init() {

        bankService = Mockito.mock(BankService.class);
        bank = new Bank(bankService);
    }

    @Test
    void shouldAddCustomer() {
        Customer customer = new Customer("Emma", "emma22@mail.com");
        bank.addCustomer(customer);
        Assertions.assertTrue(bank.getCustomerList().containsKey(customer.getId()));
    }

    @ParameterizedTest
    @CsvSource({"Emma,emma22@mail.com,150.50"})
    void shouldRemoveCustomer(String name, String mail, double balance) throws RemoveCustomerException {
        Customer customer = new Customer(name,mail,balance);
        bank.addCustomer(customer);
        bank.addCustomer(new Customer("Bella","bella@mail.com"));
        bank.removeCustomer(customer);
        Assertions.assertFalse(bank.getCustomerList().containsKey(customer.getId()));
    }

    @ParameterizedTest
    @CsvSource({"Sue Smith,suesmith@mail.com,-10.2"})
    void shouldNotRemoveCustomer(String name, String mail, double balance) {
        Customer customer = new Customer(name,mail,balance);
        bank.addCustomer(customer);
        bank.addCustomer(new Customer("Bella","bella@mail.com"));
        Assertions.assertThrows(RemoveCustomerException.class,()-> bank.removeCustomer(customer));
    }

    @Test
    void shouldNotDoTransfer() {
        Customer customer = new Customer("Something","something@mail.com",-150.50);
        Assertions.assertThrows(BankException.class, () ->  bank.doTransfer(customer,30.99));
    }
}
