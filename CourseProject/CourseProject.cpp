#include "CourseProject.h"

#define delimeter cout << ANSI_YELLOW << setw(120) << setfill('-') << "\n" << ANSI_RESET;

using namespace std;

const char* ANSI_RESET = "\033[0m";
const char* ANSI_GREEN = "\x1B[32m";
const char* ANSI_YELLOW = "\x1B[0;33m";
const char* ANSI_RED = "\x1B[31m";


BuildingsQueue buildingsQueue;

void fillDataForQueue() {
    Date date1(24, 4, 2024);
    Date date2(15, 10, 2025);
    Date date3(17, 5, 2023);
    Date date4(17, 3, 2024);
    
    Person person1(Date(28, 9, 1997),  "Oleksii", "Pryadko", "software engineer", 20000, true);
    Person person2(Date(15, 10, 1985), "Oleh", "Vynnyk", "SEO", 40000, true);
    Person person3(Date(23, 11, 1993), "Vitalii", "Tsal'", "mechainic", 12000, true);
    Person person4(Date(16, 6, 2000),  "Yana", "Zyst", "hairdresser", 13000, false);

    buildingsQueue.add(person1, date1);
    buildingsQueue.add(person2, date2);
    buildingsQueue.add(person3, date3);
    buildingsQueue.add(person4, date4);
}

void showQueueWithIndexRangeMenu()
{
    int from;
    int to;

    cout << "Enter the index from which you want to show the queue: ";
    cin >> from;
    from--;

    BuildingsQueue::Iterator iter = buildingsQueue.at(from);

    cout << "Enter the index to which you want to show the queue(inclusively): ";
    cin >> to;
    to--;
    
    cout << "Buildings Queue { " << endl;
    for (; from <= to; from++, iter++)
    {
        cout << from + 1 << ".)" << iter->first
             << "Waiting Time: " << iter->second << endl << endl;
    }
    cout << "}" << endl;
}

void sortQueueMenu()
{
    buildingsQueue.sortByTheLengthOfStay();
    cout << ANSI_GREEN << "Queue was sorted by decreasing waiting time" << ANSI_RESET << endl;
}

void addNewPersonMenu()
{
    Person person;
    Date date;
    
    cout << "New person" << endl;
    cin >> person;
    cout << "Enter person waiting time: " << endl;
    cin >> date;

    buildingsQueue.add(person, date);
    cout << ANSI_GREEN << "Person has been added to queue successfully" << ANSI_RESET << endl;
}

void incrementWaitingTimeMenu()
{
    int index, days;

    cout << "Enter person index you want to increment waiting time: ";
    cin >> index;
    index--;

    Person person = buildingsQueue.getPerson(index);
    Date waitingTime = buildingsQueue.getWaitingTime(index);

    cout << index + 1 << ".)" << person.fullname() << endl;
    cout << ANSI_YELLOW << "Current " << ANSI_RESET 
        << "waiting time : "<< waitingTime << endl;

    cout << "Enter days you want increment/decrement person waiting time: ";
    cin >> days;

    waitingTime += days;
    buildingsQueue.setWaitingTime(index, waitingTime);

    cout << ANSI_GREEN << "Updated " << ANSI_RESET << "waiting time : " << waitingTime << endl;
}

void removePersonFromQueueMenu()
{
    int index;
    
    cout << "Enter person index you want to remove from queue: ";
    cin >> index;

    buildingsQueue.remove(index - 1);

    cout << ANSI_GREEN << "Person has been deleted from queue successfully" << ANSI_RESET << endl;
}

void lateBindingDemoMenu()
{
    Date *date1 = new Date(24, 4, 2022);
    Date *date2 = new Person;

    cout << "Date format from Date object "   << date1->dateToString() << endl;
    cout << "Date format from Person object " << date2->dateToString() << endl;
}

void showMainMenu()
{
    cout << setw(60) << "BuildingsQueue Demo" << endl;

    bool exitState = false;
    int action;

    while (!exitState)
    {
        try 
        {
            delimeter;
            cout << "1.)Show Buildings queue " <<  endl;
            cout << "2.)Show Buildings queue with the specified index range" << endl;
            cout << "3.)Sort queue by decreasing waiting time" << endl;
            cout << "4.)Add new person to queue " << endl;
            cout << "5.)Delete person in queue by index " << endl;
            cout << "6.)Increment/decrement person waiting time" << endl << endl;

            cout << "8.)Late Binding mechaninsm Demo" << endl;
            cout << "9.)Exit " << endl << endl;

            cout << "Choose your action: ";
            cin >> action;
            delimeter;

            switch (action)
            {
            case 1:
                cout << buildingsQueue;
                break;
            case 2:
                showQueueWithIndexRangeMenu();
                break;
            case 3:
                sortQueueMenu();
                break;
            case 4:
                addNewPersonMenu();
                break;
            case 5:
                removePersonFromQueueMenu();
                break;
            case 6:
                incrementWaitingTimeMenu();
                break;
            case 8:
                lateBindingDemoMenu();
                break;
            case 9:
                exitState = true;
                cout << setfill(' ') << setw(50) << ANSI_GREEN << "Goodbye!" << ANSI_RESET << endl;
                break;
            default:
                cout << ANSI_RED <<
                    "You have entered the wrong action! " << ANSI_RESET << "Please try again." << endl;
            }
        }
        catch (std::runtime_error e)
        {
            cout << ANSI_RED   << "Error" 
                 << ANSI_RESET << ": " << e.what() << endl;
        }
        cin.clear();                               //clear errors/bad flags on cin
        cin.ignore(cin.rdbuf()->in_avail(), '\n'); //precise amount of ignoring
        cin.rdbuf()->in_avail();                   //returns the exact number of characters in the cin buffer.
    }
}

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    fillDataForQueue();
    showMainMenu();

    return 0;
}