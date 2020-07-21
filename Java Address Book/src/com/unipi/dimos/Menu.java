package com.unipi.dimos;

import java.io.IOException;
import java.util.InputMismatchException;
import java.util.Scanner;

class Menu {

    private Contacts cont = new Contacts();

    void menuTemplate() throws IOException {
        cont.insertText();
        boolean loop = true;
        while (loop) {

            Scanner menuSelection = new Scanner(System.in);

            System.out.println("~ Application AddressBook ~");
            System.out.println("Please choose something from the menu below:");
            System.out.println("-----------------------------------------------");
            System.out.println("1.      Show all available addresses");
            System.out.println("2.      Add new contact");
            System.out.println("3.      Search contact by name");
            System.out.println("4.      Search contact by number");
            System.out.println("5.      Edit contact by name");
            System.out.println("6.      Delete contact by name");
            System.out.println("7.      Exit ");
            System.out.println("-----------------------------------------------");
            System.out.print("Your input:");




            System.out.println("\n");

            Scanner userInput = new Scanner(System.in);

            try {
                int intInput = menuSelection.nextInt();
                if (intInput == 1) {
                    System.out.println("Here are all available contacts:");

                    cont.showContacts();

                    System.out.println("Do you want to go back to Main Menu?(Y/N)");

                    String confirm;

                    do {
                        System.out.println("Please Y or N only!!!\n");
                        confirm = userInput.nextLine();
                        if (confirm.equals("Y")) {
                            System.out.println("Heading back to main menu... \n");
                            loop = true;
                        } else if (confirm.equals("N")) {
                            System.out.println("~ Thanks for using my app :) ~ \n");
                            loop = false;
                        }


                    } while (confirm.isEmpty());
                    break;

                } else if (intInput == 2) {
                    //Getting the name of the contact
                    System.out.print("Please type contact's name:");

                    String contactName = userInput.nextLine();


                    //Getting the mail of the contact
                    System.out.print("Please type contact's mail:");


                    String contactMail = userInput.nextLine();


                    //Getting the phone number of the contact
                    System.out.print("Please type contact's phone number:");

                    String contactNumber = userInput.nextLine();

                    //Getting the address of the contact
                    System.out.print("Please type contact's address:");

                    String contactAddress = userInput.nextLine();

                    cont.addContact(contactName, contactMail, contactNumber, contactAddress);
                    System.out.println("~ New contact has been successfully registered!! :) ~\n");


                    System.out.println("Do you want to go back to Main Menu?(Y/N)");

                    String confirm;

                    do {
                        System.out.println("Please Y or N only!!!\n");
                        confirm = userInput.nextLine();

                        if (confirm.equals("Y")) {
                            System.out.println("Heading back to main menu... \n");

                        } else if (confirm.equals("N")) {
                            System.out.println("~ Thanks for using my app :) ~ \n");
                            loop = false;
                        }
                    } while (confirm.isEmpty());


                } else if (intInput == 3) {
                    System.out.print("Please type contact's name to search:");

                    String contactName = userInput.nextLine();

                    cont.searchName(contactName);

                    System.out.println("Do you want to go back to Main Menu?(Y/N)");

                    String confirm;

                    do {
                        System.out.println("Please Y or N only!!!\n");

                        confirm = userInput.nextLine();

                        if (confirm.equals("Y")) {
                            System.out.println("Heading back to main menu... \n");

                        } else if (confirm.equals("N")) {
                            System.out.println("~ Thanks for using my app :) ~ \n");
                            loop = false;
                        }
                    } while (confirm.isEmpty());


                } else if (intInput == 4) {
                    System.out.print("Please type contact's phone to search:");

                    String contactPhone = userInput.nextLine();
                    cont.searchPhone(contactPhone);

                    System.out.println("Do you want to go back to Main Menu?(Y/N)");

                    String confirm;

                    do {
                        System.out.println("Please Y or N only!!!\n");

                        confirm = userInput.nextLine();

                        if (confirm.equals("Y")) {
                            System.out.println("Heading back to main menu... \n");

                        } else if (confirm.equals("N")) {
                            System.out.println("~ Thanks for using my app :) ~ \n");
                            loop = false;
                        }
                    } while (confirm.isEmpty());


                } else if (intInput == 5) {
                    cont.editContact();

                    System.out.println("Do you want to go back to Main Menu?(Y/N)");

                    String confirm;

                    do {
                        System.out.println("Please Y or N only!!!\n");

                        confirm = userInput.nextLine();

                        if (confirm.equals("Y")) {
                            System.out.println("Heading back to main menu... \n");

                        } else if (confirm.equals("N")) {
                            System.out.println("~ Thanks for using my app :) ~ \n");
                            loop = false;
                        }
                    } while (confirm.isEmpty());

                } else if (intInput == 6) {
                    System.out.print("Please type contact's name to remove:");


                    String contactName = userInput.nextLine();

                    cont.removeContact(contactName);

                    System.out.println("Do you want to go back to Main Menu?(Y/N)");

                    String confirm;

                    do {
                        System.out.println("Please Y or N only!!!\n");

                        confirm = userInput.nextLine();

                        if (confirm.equals("Y")) {
                            System.out.println("Heading back to main menu... \n");

                        } else if (confirm.equals("N")) {
                            System.out.println("~ Thanks for using my app :) ~ \n");
                            loop = false;
                        }
                    } while (confirm.isEmpty());
                } else if (intInput == 7) {
                    System.out.println("~ Thanks for using my app auf wiedersehen! :) ~");
                    break;
                }
            }
            catch(InputMismatchException e ){
                System.out.printf("Only numbers are allowed!! \n \n");
            }
        }


    }
}


