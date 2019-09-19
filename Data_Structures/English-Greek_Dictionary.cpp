#include <iostream>
#include <vector>
using namespace std;
int count = 10;

//Node Structure
struct node {
    string word, translation;
    node *left, *right;
} *root = nullptr;

//Inorder Traversal
void inorder(struct node *tmp) {
    if (tmp != nullptr) {
        inorder(tmp->left);
        cout << tmp->word << endl;
        inorder(tmp->right);
    }
}

//Create new Node
node *newNode(string newWord,string newTranslation) {
    node *temp = (struct node *)malloc(sizeof(struct node));
    temp->word=newWord;
    temp->translation =newTranslation;
    temp->left = temp->right = nullptr;
    return temp;
}

//Return Smallest Value
node *smallestValue(struct node *node) {
    struct node *current = node;
    
    while (current->left != nullptr) {
        current = current->left;
    }
    return current;
}

//Two Strings Comparison
int stringCheck(const string &a, const string &b) {

    //Equals
    if (a == b)
    {
        return 0;
    }

        //First String is greater
    else if (a.compare(b) > 0)
    {
        return 1;
    }

        //Second String is greater
    else
    {
        return -1;
    }
}

//Insert
node *insert(node *node,string insertedWord,string insertedTrans) {

    //If root is empty create new node
    if (node == nullptr) {
        return newNode(insertedWord, insertedTrans);
    }

    //Else insert word
    if (stringCheck(node->word, insertedWord) == 1) {
        node->left = insert(node->left, insertedWord, insertedTrans);
    }

    else if (stringCheck(node->word, insertedWord) == -1) {
        node->right = insert(node->right, insertedWord, insertedTrans);
    }

    
    return node;
}
//Wrapper for Insert
void Insert() {

    string word, trans;
    cout << "Please type the english word-Παρακαλώ εισάγετε την αγγλική λέξη:";
    cin >> word;
    cout << "Please type it's greek meaning(In greek)-Παρακαλώ εισάγετε τη μετάφρασής της:";
    cin >> trans;
    insert(root, word, trans);
}

//Wrapper for search
void search(node *tmp,string c) {
    vector<string> searchedWords;

    //If node is not empty
    if (tmp != nullptr) {
        
        search(tmp->left, c);
        
		//If node matches searched string
        if ((tmp->word).find(c) == 0) {
            searchedWords.push_back(tmp->word + "=" + tmp->translation);
            
            for (int i = 0; i < searchedWords.size(); i++) 
			{
                cout << searchedWords[i] << endl;
            }
        }
        //For Right Subtree too
        search(tmp->right, c);
    }
}

//Wrapper for Search
void Search() {
    //If node is not empty
    if (root != nullptr) {
        string w;
        cout << "\nType the letters of the word that you want to be searched-Εισάγετε τα γράμματα της λέξης που θέλετε να γίνει αναζήτηση:";
        cin >> w;
        cout << "\nWords found-Οι λέξεις που βρέθηκαν είναι οι εξής:\n" << endl;
        search(root, w);
    }else {
        //If node is empty
        cout << "Dictionary is empty-Το λεξικό είναι άδειο!!" << endl;
    }
}

//Remove Node
node *deleteNode(node *root,string k) {
    //If node is empty
    if (root == nullptr)
        return root;

    //Search ancestors to be removed
    if (root->word > k) {
        root->left = deleteNode(root->left, k);
        return root;
    } else if (root->word < k) {
        root->right = deleteNode(root->right, k);
        return root;
    }

    //When root is deleted

    //One child is empty
    if (root->left == nullptr) {
        node *temp = root->right;
        delete root;
        return temp;
    } else if (root->right == nullptr) {
        node *temp = root->left;
        delete root;
        return temp;
    }

        //If both children exist
    else {

        struct node *temp = smallestValue(root->right);
        root->word = temp->word;
        root->right = deleteNode(root->right, temp->word);
    }

    return root;
}
//Wrapper for deleteNode
void Delete() {
    if (root != nullptr) {
        string s;
        cout << "Please type the word that you want to delete-Παρακαλώ εισάγετε τη λέξη για διαγραφή:";
        cin >> s;
        deleteNode(root, s);

    }

    else {
        cout << "The dictionary doesn't contain the word you typed-Το λεξικό δεν περιέχει την λέξη που γράψατε!" << endl;
    }
}

void print2DUtil(node *tmp,int space) {

    //Node is empty
    if (tmp == nullptr)
        return;

    //Increase distance between levels
    space += count;

    //Editting right child
    print2DUtil(tmp->right, space);

    //Print node after counting 
    cout << endl;
    for (int i = count; i < space; i++)
        cout << " ";
    cout << tmp->word << "\n";

    //Editting left child
    print2DUtil(tmp->left, space);
}

// Wrapper for PRINT2DUTIL()
void print2D(node *tmp) {
    if (tmp == nullptr) {
        cout << "\nDictionary is empty-Το λεξικό είναι κενό!" << endl;
    }

    else {
        //SPACE COUNT = 0
        print2DUtil(tmp, 0);
    }
}

int main() {

    root = newNode("Cat", "Γάτα");
    insert(root, "Dolphin", "Δελφινι");
    insert(root, "Dog", "Σκύλος");
    insert(root, "Box", "Κουτί");
    insert(root, "Lion", "Λιοντάρι");
    insert(root, "Bat", "Νυχτερίδα");
    
	//Console
    int ch;
    cout<<"~ Welcome to my English-Greek Dictionary - Καλώς ήρθατε στο Αγγλοελληνικό λεξικό μου! ~"<<endl;
    while (ch != 5) {
        cout << "\n1.Search-Αναζήτηση\n"
             << "2.Add-Προσθήκη\n"
             << "3.Show Dictionary-Εμφάνιση Λεξικού\n"
             << "4.Delete-Διαγραφή\n"
             << "5.Exit-Έξοδος\n"
             << "\nPlease choose something('Or press 5 to exit')-Παρακαλώ Επιλέξτε('Η πιέστε 5 για έξοδο):";

        cin >> ch;
        switch (ch) {
            case 1: {
                Search();
                break;
            }
            case 2: {
                Insert();
                break;
            }

            case 3: {
                print2D(root);
                break;
            }

            case 4: {
                Delete();
                break;
            }
        }
    }

    return 0;
}
