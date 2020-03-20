/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package view.backing;

import static java.lang.Math.round;
import java.util.ArrayList;
import java.util.List;
import javax.inject.Named;
import javax.enterprise.context.RequestScoped;

/**
 *
 * @author Damian
 */
@Named(value = "dtStudents")
@RequestScoped
public class DTStudents {

    private List<Student> students;
    private final static String[] names;

    private final static String[] surnames;

    static {
        names = new String[10];
        names[0] = "John";
        names[1] = "Paul";
        names[2] = "Zoey";
        names[3] = "Kate";
        names[4] = "Joseph";
        names[5] = "Michael";
        names[6] = "Mary";
        names[7] = "Robert";
        names[8] = "Leslie";
        names[9] = "Ron";

        surnames = new String[10];
        surnames[0] = "Swanson";
        surnames[1] = "Scott";
        surnames[2] = "Holden";
        surnames[3] = "Doe";
        surnames[4] = "Krautz";
        surnames[5] = "Haverford";
        surnames[6] = "Lewis";
        surnames[7] = "Pitch";
        surnames[8] = "Plaza";
        surnames[9] = "O'Reiley";
    }

    public DTStudents() {
        students = generateStudents();
    }
    
    private List<Student> generateStudents() {
        List<Student> tmpStudents = new ArrayList<>();
        for (int i = 0; i < 10; i++) {
            tmpStudents.add(new Student(getRandomName(), getRandomSurname(), getRandomAverage()));
        }
        return tmpStudents;
    }

    public List<Student> getStudents() {
        return students;
    }

    private String getRandomName() {
        return names[(int) (Math.random() * 10)];
    }

    private String getRandomSurname() {
        return surnames[(int) (Math.random() * 10)];
    }
    
    private double getRandomAverage(){
        return round((Math.random() * 2 + 3) * 100)/100.0;
    }

}
