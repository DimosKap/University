package com.unipi.dimos;


import java.io.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

class Contacts {
    private List<String> contactsList = new ArrayList<>();


    void insertText() throws IOException {
        File file = new File("contacts.txt");
        BufferedReader br = new BufferedReader(new FileReader(file));
        String st;
        while ((st = br.readLine()) != null) {
            contactsList.add(st);
        }
    }


    void showContacts() {
        int listLength = contactsList.size();
        if (listLength == 0) {
            System.out.println("~ Address Book is empty ~\n");
        } else {
            for (int i = 0; i < listLength; i++) {
                System.out.println(i + 1 + "." + contactsList.get(i));
            }
            System.out.println(" ");
        }
    }


    void addContact(String name,String email,String phone,String address) throws IOException {

        //Writing new contact to the .txt file
        contactsList.add(name + " / " + email+ " / " + phone+ " / " + address);


        BufferedWriter writer = new BufferedWriter(new FileWriter("contacts.txt"));

        for (String s : contactsList) {
            writer.write(s + "\n");
        }
        writer.close();


    }


    void searchName(String name) throws IOException {

        File contactFile = new File("contacts.txt");

        BufferedReader reader = new BufferedReader(new FileReader(contactFile));

        String currentLine;



        while ((currentLine = reader.readLine()) != null) {


            String[] lines = currentLine.split(System.getProperty("line.separator"));


            for (String line : lines) {
                if (line.startsWith(name)) {
                    System.out.println("Contact found: " + line);
                }
            }
        }

    }


    void searchPhone(String phone) throws IOException {
        File contactFile = new File("contacts.txt");

        BufferedReader reader = new BufferedReader(new FileReader(contactFile));



        String line;

        while ((line = reader.readLine()) != null) {

            String[] lines = line.split(" / ");

            for (String s :
                    lines) {
                if (s.equals(phone)) {
                    System.out.println(line);
                }
            }

        }
        reader.close();
    }


    void removeContact(String name) throws IOException {




        File inputFile = new File("contacts.txt");
        File tempFile = new File("tmp.txt");

        BufferedReader reader = new BufferedReader(new FileReader(inputFile));
        BufferedWriter writer = new BufferedWriter(new FileWriter(tempFile));

        String currentLine;


        while ((currentLine = reader.readLine()) != null) {
            String[] lines = currentLine.split(System.getProperty("line.separator"));

            for (int i = 0; i < lines.length; i++) {

                if (lines[i].startsWith(name)) {

                        System.out.println("Is is the contact you want to delete?(Y/N)");
                        System.out.println(lines[i]);

                    String answer;
                        do {
                            Scanner deleteConf = new Scanner(System.in);
                            answer = deleteConf.nextLine();

                            if (answer.equals("Y")) {
                                lines[i] = "";
                                System.out.println("~ Contact removed successfully! ~ \n");
                            }
                            else if(answer.equals("N"))continue;
                            System.out.println("Please Y or N only!");
                        } while(answer.isEmpty());



                }

                StringBuilder finalStringBuilder = new StringBuilder();
                for (String s : lines) {
                    if (!s.equals("")) {
                        finalStringBuilder.append(s).append(System.getProperty("line.separator"));
                    }
                }
                String finalString = finalStringBuilder.toString();
                writer.write(finalString);

            }
        }

            writer.close();
            reader.close();

            BufferedReader reader2 = new BufferedReader(new FileReader(tempFile));
            BufferedWriter writer2 = new BufferedWriter(new FileWriter(inputFile));

            String currentlines;

            while ((currentlines = reader2.readLine()) != null) {
                writer2.write(currentlines + "\n");
            }
            writer2.close();
            reader2.close();




    }

    private void deleteIt(String name) throws IOException {


        File inputFile = new File("contacts.txt");
        File tempFile = new File("tmp.txt");

        BufferedReader reader = new BufferedReader(new FileReader(inputFile));
        BufferedWriter writer = new BufferedWriter(new FileWriter(tempFile));

        String currentLine;


        while ((currentLine = reader.readLine()) != null) {
            String[] lines = currentLine.split(System.getProperty("line.separator"));

            for (int i = 0; i < lines.length; i++) {

                if (lines[i].startsWith(name)) {
                    lines[i] = "";
                }

                StringBuilder finalStringBuilder = new StringBuilder();
                for (String s : lines) {
                    if (!s.equals("")) {
                        finalStringBuilder.append(s).append(System.getProperty("line.separator"));
                    }
                }
                String finalString = finalStringBuilder.toString();
                writer.write(finalString);

            }
        }

        writer.close();
        reader.close();

        BufferedReader reader2 = new BufferedReader(new FileReader(tempFile));
        BufferedWriter writer2 = new BufferedWriter(new FileWriter(inputFile));

        String currentlines;

        while ((currentlines = reader2.readLine()) != null) {
            writer2.write(currentlines + "\n");
        }
        writer2.close();
        reader2.close();
    }


    void editContact() throws IOException {



        File contactFile = new File("contacts.txt");

        BufferedReader reader = new BufferedReader(new FileReader(contactFile));


        String currentLine;

        System.out.print("Please type the name of the contact you want to edit:");
        Scanner nameScan = new Scanner(System.in);

        String contactName = nameScan.nextLine();

        while ((currentLine = reader.readLine()) != null) {


            String[] lines = currentLine.split(System.getProperty("line.separator"));


           // for (int i = 0; i < lines.length; i++) {
              for (String s:lines){
                if (s.startsWith(contactName)) {
                    System.out.println("Contact: " + s + "\n");


                    String[] line = s.split(" / ");


                    String selection;


                        System.out.print("Please type what you want to change(Name/Email/Phone/Address):");
                        Scanner scan = new Scanner(System.in);
                        selection = scan.nextLine();
                    do {
                        if (selection.equals("Name")) {
                            //deleteIt(line[0]);
                            Scanner name = new Scanner(System.in);
                            System.out.print("Please type the new name:");
                            String newName = name.nextLine();

                            line[0] = newName;
                            addContact(line[0], line[1], line[2], line[3]);
                            System.out.println("~ Contact's name  has been successfully changed! ~");
                        }

                        if (selection.equals("Email")) {
                            Scanner email = new Scanner(System.in);
                            System.out.print("Please type the new name:");
                            String newEmail = email.nextLine();
                            line[1] = newEmail;
                            addContact(line[0], line[1], line[2], line[3]);
                        }
                        if (selection.equals("Phone")) {
                            Scanner phone = new Scanner(System.in);
                            System.out.print("Please type the new phone:");
                            String newPhone = phone.nextLine();
                            line[2] = newPhone;
                            addContact(line[0], line[1], line[2], line[3]);
                        }
                        if (selection.equals("Address")) {
                            Scanner address = new Scanner(System.in);
                            System.out.print("Please type the new address:");
                            String newAddress = address.nextLine();

                            line[3] = newAddress;
                            addContact(line[0], line[1], line[2], line[3]);
                        }
                        System.out.println("Invalid input.Please Try Again.");
                    }while(selection.isEmpty());


                }

              }
        }



    }




}