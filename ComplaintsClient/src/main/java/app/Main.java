/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package app;

import complaint.Complaint;
import java.util.List;
import java.util.stream.Collectors;
import javax.ws.rs.client.Client;
import javax.ws.rs.client.ClientBuilder;
import javax.ws.rs.client.Entity;
import javax.ws.rs.core.GenericType;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;

/**
 *
 * @author Damian
 */
public class Main {

    public static void main(String[] args) {
        Client client = ClientBuilder.newClient();

        List<Complaint> all
                = client.target("http://localhost:8080/Complaints/"
                        + "resources/complaints")
                        .request(MediaType.APPLICATION_JSON)
                        .get(new GenericType<List<Complaint>>() {
                        });
        System.out.println("1. All complaints: \n" + all);

        
        List<Complaint> openedFromAll = all.stream().filter((t) -> "open".equals(t.getStatus())).collect(Collectors.toList());
        Integer openedId = openedFromAll.size()>0 ? openedFromAll.get(0).getId() : null;
        
        if(openedId!=null){
        Complaint opened
                = client.target("http://localhost:8080/Complaints/"
                        + "resources/complaints/"+openedId)
                        .request(MediaType.APPLICATION_JSON)
                        .get(Complaint.class);
        System.out.println("2. First opened complaint: \n" + opened);
        
        opened.setStatus("closed");
        Response response 
                = client.target("http://localhost:8080/Complaints/"
                        + "resources/complaints/"+openedId)
                        .request(MediaType.TEXT_PLAIN)
                        .put(Entity.json(opened));
        opened
                = client.target("http://localhost:8080/Complaints/"
                        + "resources/complaints/"+openedId)
                        .request(MediaType.APPLICATION_JSON)
                        .get(Complaint.class);
        System.out.println("3. Change status("+response.getStatus()+")\n"+opened);
        
        
        List<Complaint> allOpened
                = client.target("http://localhost:8080/Complaints/"
                        + "resources/complaints/?status=open")
                        .request(MediaType.APPLICATION_JSON)
                        .get(new GenericType<List<Complaint>>() {
                        });
        System.out.println("4. All opened complaints: \n" + allOpened);
        }
        else{
            System.out.println("There is no opened complaints.");
        }


        client.close();
    }
}
