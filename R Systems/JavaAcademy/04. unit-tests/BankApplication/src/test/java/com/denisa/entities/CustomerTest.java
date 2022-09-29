package com.denisa.entities;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.function.Executable;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;
import org.mockito.Mockito;

public class CustomerTest {

    private Customer customer;

    @ParameterizedTest
    @CsvSource("Joe,joe_345@mail.com")
    void nameShouldBeLonger(String name, String mail) {
        Assertions.assertThrows(Exception.class, () -> new Customer(name,mail));
    }

    @ParameterizedTest
    @CsvSource("Joe Smith,joe_345@mail.com")
    void nameShouldBeValid(String name, String mail) {
        Assertions.assertDoesNotThrow( () -> new Customer(name,mail));
    }

    @ParameterizedTest
    @CsvSource({"Joe Smith,joe@mail","Joe Smith,@mail.com","Joe Smith,joe.com"})
    void emailShouldNotBeValid(String name, String mail) {
        Assertions.assertThrows(Exception.class, () -> new Customer(name,mail));
    }

    @ParameterizedTest
    @CsvSource("Joe Smith,joe_smith@mail.com")
    void emailShouldBeValid(String name, String mail) {
        Assertions.assertDoesNotThrow( () -> new Customer(name,mail));
    }
}
