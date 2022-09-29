package gson.custom;

import com.google.gson.annotations.Expose;

public class Dog {
    @Expose
    private int Age;
    @Expose
    private String name;
    @Expose
    private boolean isBoy;
    @Expose
    private double chipCode;
    @Expose
    private Double weight;
    @Expose(serialize = false, deserialize = true)
    private Integer DogYears;
    @Expose
    private Boolean isSenior;
    private transient String breed;

    public Dog(int age, String name, boolean isBoy, double chipCode, Double weight, Integer dogYears, Boolean isSenior, String breed) {
        Age = age;
        this.name = name;
        this.isBoy = isBoy;
        this.chipCode = chipCode;
        this.weight = weight;
        DogYears = dogYears;
        this.isSenior = isSenior;
        this.breed = breed;
    }

    public int getAge() {
        return Age;
    }

    public void setAge(int age) {
        Age = age;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public boolean isBoy() {
        return isBoy;
    }

    public void setBoy(boolean boy) {
        isBoy = boy;
    }

    public double getChipCode() {
        return chipCode;
    }

    public void setChipCode(double chipCode) {
        this.chipCode = chipCode;
    }

    public Double getWeight() {
        return weight;
    }

    public void setWeight(Double weight) {
        this.weight = weight;
    }

    public Integer getDogYears() {
        return DogYears;
    }

    public void setDogYears(Integer dogYears) {
        DogYears = dogYears;
    }

    public Boolean getSenior() {
        return isSenior;
    }

    public void setSenior(Boolean senior) {
        isSenior = senior;
    }

    public String getBreed() {
        return breed;
    }

    public void setBreed(String breed) {
        this.breed = breed;
    }

    @Override
    public String toString() {
        return "Dog{" +
                "Age=" + Age +
                ", name='" + name + '\'' +
                ", isBoy=" + isBoy +
                ", chipCode=" + chipCode +
                ", weight=" + weight +
                ", DogYears=" + DogYears +
                ", isSenior=" + isSenior +
                ", breed='" + breed + '\'' +
                '}';
    }
}
