package com.denisa.exceptions;

public class BankException extends Exception {
    public BankException() {
        super("The transfer could not be performed.");
    }

    public BankException(String errorMessage) {
        super("The transfer could not be performed. Sum: " + errorMessage);
    }
}
