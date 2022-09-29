package com.denisa.exceptions;

public class RemoveCustomerException extends  Exception{
    public RemoveCustomerException(String errorMessage) {
        super(errorMessage);
    }

    public RemoveCustomerException() {
        super("! Customer must not have negative account balance !");
    }
}
