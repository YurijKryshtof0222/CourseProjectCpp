#include "CourseProject.h"

#define delimeter cout << ANSI_GREEN << setw(120) << setfill('-') << "" << ANSI_RESET << endl;

using namespace std;

const char* ANSI_GREEN = "\x1B[32m";
const char* ANSI_YELLOW = "\e[0;33m";
const char* ANSI_RESET = "\033[0m";
const char* ANSI_MAGENTA = "\x1B[35m";
const char* ANSI_RED = "\x1B[31m";
const char* ANSI_BLUE = "\x1B[34m";

BuildingsQueue buildingsQueue;

void fillDataForQueue() {
    Date date1(24, 4, 2024);
    Date date2(15, 10, 2025);
    Date date3(17, 5, 2023);
    Date date4(17, 3, 2024);
    
    Person person1(Date(28, 9, 1997), "Oleksii", "Pryadko", "software engineer", 20000, true);
    Person person2(Date(15, 10, 1985), "Oleh", "Vynnyk", "SEO", 40000, true);
    Person person3(Date(23, 11, 1993), "Vitaliy", "Tsal'", "mechainic", 12000, true);
    Person person4(Date(16, 6, 2000), "Yana", "Zyst", "hairdresser", 13000, false);

    buildingsQueue.add(person1, date1);
    buildingsQueue.add(person2, date2);
    buildingsQueue.add(person3, date3);
    buildingsQueue.add(person4, date4);
}

void showWithIndexRange()
{
    int from;
    int to;

    cout << "Enter the index from which you want to show the queue: ";
    cin >> from;
    from--;
    buildingsQueue.throwIfIndexIsOutOfBounds(from);

    cout << "Enter the index to which you want to show the queue(inclusively): ";
    cin >> to;
    to--;
    buildingsQueue.throwIfIndexIsOutOfBounds(to);

    BuildingsQueue::Iterator iter = buildingsQueue.at(from);
    
    cout << "Buildings Queue { " << endl;
    for (; from <= to; from++, iter++)
    {
        cout << from + 1 << ".)" << iter->first
             << "Waiting Time: " << iter->second << endl;
    }
    cout << "}" << endl;
}

void addNewPerson()
{
    Person person;
    Date date;
    
    cout << "New person" << endl;
    cin >> person;
    cout << "Enter person waiting time " << endl;
    cin >> date;

    buildingsQueue.add(person, date);
}

void incrementWaitingTime()
{
    int index, days;

    cout << "Enter person index you want to increment waiting time: ";
    cin >> index;
    index--;
    buildingsQueue.throwIfIndexIsOutOfBounds(index);

    Person person = buildingsQueue.getPerson(index);
    Date waitingTime = buildingsQueue.getWaitingTime(index);

    cout << index + 1 << ".)" << person.fullname() << endl;
    cout << "Current waiting time: "<< waitingTime << endl;

    cout << "Enter days you want increment/decrement person waiting time: ";
    cin >> days;

    waitingTime += days;
    buildingsQueue.setWaitingTime(index, waitingTime);

    cout << "Updated waiting time: " << waitingTime << endl;
}

void removePersonFromQueue()
{
    int index;
    
    cout << "Enter person index you want to remove from queue: ";
    cin >> index;

    buildingsQueue.remove(index - 1);
}

void showMenu()
{
    cout << setw(60) << "BuildingsQueue Demo" << endl;

    bool exit = false;
    int action;

    while (!exit)
    {
        try 
        {
            delimeter;
            cout << "1.)Show Buildings queue " <<  endl;
            cout << "2.)Show Buildings queue with the specified index range" << endl;
            cout << "3.)Sort queue by decreasing length of stay" << endl;
            cout << "4.)Add new person to queue " << endl;
            cout << "5.)Delete person in queue by index " << endl;
            
            cout << "6.)Increment/decrement person waiting time" << endl;
            //cout << "8.)+= demo " << endl << endl;

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
                showWithIndexRange();
                break;
            case 3:
                sort();
                break;
            case 4:
                addNewPerson();
                break;
            case 5:
                removePersonFromQueue();
                break;
            case 6:
                incrementWaitingTime();
                break;
            case 9:
                exit = true;
                break;
            default:
                cout << "You have entered the wrong action! Please try again." << endl;
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

void sort()
{
    buildingsQueue.sortByTheLengthOfStay();
    cout << ANSI_BLUE << "Queue was sorted by decreasing waiting time" << ANSI_RESET << endl;
}

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    fillDataForQueue();
    showMenu();

    return 0;
}