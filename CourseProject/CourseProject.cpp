#include <iostream>
#include <iomanip>
#include <windows.h>

#include "Date.h"
#include "Person.h"
#include "BuildingsQueue.h"
#include "CourseProject.h"

#define delimeter cout << setw(120) << setfill('-') << "" << endl;

using namespace std;

BuildingsQueue queue;

void fillDataForQueue() {
    Date date1(24, 4, 2024);
    Date date2(15, 10, 2025);
    Date date3(17, 5, 2023);
    Date date4(17, 3, 2024);
    
    Person person1(Date(28, 9, 1997), "Oleksii", "Pryadko", "software engineer", 20000, true);
    Person person2(Date(15, 10, 1985), "Oleh", "Vynnyk", "SEO", 40000, true);
    Person person3(Date(23, 11, 1993), "Vitaliy", "Tsal'", "mechainic", 12000, true);
    Person person4(Date(16, 6, 2000), "Yana", "Zyst", "hairdresser", 13000, false);

    queue.add(person1, date1);
    queue.add(person2, date2);
    queue.add(person3, date3);
    queue.add(person4, date4);
}

void addNewPerson()
{
    cout << "New person" << endl;
    Person person;
    cin >> person;
    cout << "Enter person waiting time " << endl;
    Date date;
    cin >> date;

    queue.add(person, date);
}

void removePersonFromQueue()
{
    cout << "Enter person index you want to remove from queue: " << endl;
    int index;
    cin >> index;
    queue.remove(index);
}

void showMenu()
{
    cout << setw(60) << "BuildingQueue Demo" << endl;
    

    bool exit = false;
    int action;

    while (!exit)
    {
        try 
        {
            delimeter;
            cout << "1.)Show Buildings queue " << endl;
            cout << "2.)Add new person to queue " << endl;
            cout << "3.)Delete person in queue by index " << endl;
            cout << "4.)Exit " << endl << endl;

            cout << "Choose your action: ";
            cin >> action;
            delimeter;

            switch (action)
            {
            case 1:
                cout << queue;
                break;
            case 2:
                addNewPerson();
                break;
            case 3:
                cout << queue;
                break;
            case 4:
                exit = true;
                break;
            default:
                cout << "You have entered the wrong action! Please try again." << endl;
            }
        }
        catch (std::runtime_error e)
        {
            cout << e.what();
        }
        cin.clear(); //clear errors/bad flags on cin
        cin.ignore(cin.rdbuf()->in_avail(), '\n');//precise amount of ignoring
        cin.rdbuf()->in_avail(); //returns the exact number of characters in the cin buffer.
    }
}

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    fillDataForQueue();
    showMenu();

    return 0;
}