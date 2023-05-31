#include "CourseProject.h"

#define delimeter cout << ANSI_YELLOW << setw(120) << setfill('-') << "\n" << ANSI_RESET << setfill(' ');

using namespace std;

const char* ANSI_RESET = "\033[0m";
const char* ANSI_RED = "\x1B[31m";
const char* ANSI_GREEN = "\x1B[32m";
const char* ANSI_YELLOW = "\x1B[0;33m";
const char* ANSI_BLUE = "\x1B[36m";

BuildingsQueue buildingsQueue;

void fillDataForQueue() {
    Date date1(24, 4, 2024);
    Date date2(15, 10, 2025);
    Date date3(17, 5, 2023);
    Date date4(17, 3, 2024);
    
    Person person1(Date(28, 9, 1997),  "Oleksii", "Pryadko", "software engineer", 20000, MALE);
    Person person2(Date(15, 10, 1985), "Oleh", "Vynnyk", "SEO", 40000, MALE);
    Person person3(Date(23, 11, 1993), "Vitalii", "Tsal'", "mechainic", 12000, MALE);
    Person person4(Date(16, 6, 2000),  "Yana", "Zyst", "hairdresser", 13000, FEMALE);
    Person person4(Date(2, 3, 1969),  "Billy", "Heringhton", "Locksmith", 17000, MALE);

    buildingsQueue.add(person1, date1);
    buildingsQueue.add(person2, date2);
    buildingsQueue.add(person3, date3);
    buildingsQueue.add(person4, date4);
}

void showQueueWithIndexRangeMenu()
{
    int from;
    int to;

    cout << "Enter the index from which you want to show the queue: " << ANSI_YELLOW;
    cin >> from;
    from--;

    BuildingsQueue::Iterator iter = buildingsQueue.at(from);

    cout << ANSI_RESET << "Enter the index to which you want to show the queue(inclusively): " << ANSI_YELLOW;
    cin >> to;
    to--;

    cout << ANSI_RESET;
    if (buildingsQueue.isIndexOutOfBounds(to))
        throw std::runtime_error("index is out of bounds");
    
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
    
    cout << setw(55) << ANSI_BLUE << "New person" << ANSI_RESET << endl;
    person = enterDataForNewPerson();
    cout << setw(45) << ANSI_BLUE << "Person waiting time: " << ANSI_RESET << endl;
    date = enterDataForDate();

    buildingsQueue.add(person, date);
    cout << ANSI_GREEN << "Person has been added to queue successfully" << ANSI_RESET << endl;
}

void incrementWaitingTimeMenuByDays()
{
    int index, days;

    cout << "Enter person index you want to increment waiting time: " << ANSI_YELLOW;
    cin >> index;
    index--;

    Person person = buildingsQueue.getPerson(index);
    Date waitingTime = buildingsQueue.getWaitingTime(index);

    cout << index + 1 << ".)" << person.fullname() << endl;
    cout << ANSI_YELLOW << "Current " << ANSI_RESET 
        << "waiting time : "<< waitingTime << endl;

    cout << "Enter days you want increment/decrement person waiting time: " << ANSI_YELLOW;
    cin >> days;

    waitingTime += days;
    buildingsQueue.setWaitingTime(index, waitingTime);

    cout << ANSI_GREEN << "Updated " << ANSI_RESET << "waiting time : " << waitingTime << endl;
}

void incrementWaitingTimeMenuByDate()
{
    int index, days, months;

    cout << "Enter person index you want to increment waiting time : " << ANSI_YELLOW;
    cin >> index;
    index--;

    cout << ANSI_RESET;

    Person person = buildingsQueue.getPerson(index);
    Date waitingTime = buildingsQueue.getWaitingTime(index);

    cout << index + 1 << ".)" << person.fullname() << endl;
    cout << ANSI_YELLOW << "Current " << ANSI_RESET
        << "waiting time : " << waitingTime << endl;

    cout << "Enter Date you want increment/decrement person waiting time " << endl;
    Date date;

    cout << ANSI_RESET << "Enter month (from 1 to 12): " << ANSI_YELLOW;
    cin >> months;
    date.setMonth(months);

    int monthDays = Date::getMonthDays(months, waitingTime.getYear());
    cout << ANSI_RESET << "Enter day: (from 1 to " << monthDays << "): " << ANSI_YELLOW;
    cin >> days;
    date.setDay(days);
    cout << ANSI_RESET;

    string ch;

    cout << ANSI_RESET << "Increment or decrement(type \"" << ANSI_GREEN << "+" << ANSI_RESET << "\" sign for increment, other word will be considered as decrement): " << ANSI_YELLOW;
    cin >> ch;

    if (ch == "+") 
        waitingTime += date;
    else 
        waitingTime -= date;

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
    Date date{ 24, 4, 2022 };
    IDateStringFormatRetriever& retriever1 = date;
    Person person;
    IDateStringFormatRetriever& retriever2 = person;

    cout << "Date format from Date object:\t" << ANSI_YELLOW << retriever1.dateToString() << ANSI_RESET << endl;
    cout << "Date format from Person object:\t"<< ANSI_YELLOW << retriever2.dateToString() << ANSI_RESET << endl;
}

void showMainMenu()
{
    cout << setw(50) << ANSI_BLUE << "BuildingsQueue Demo" << ANSI_RESET << endl;

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
            cout << "6.)Increment/decrement person waiting time by days" << endl;
            cout << "7.)Increment/decrement person waiting time by date" << endl;
            cout << "8.)Late Binding mechaninsm Demo" << endl;
            cout << "9.)Exit " << endl << endl;

            cout << "Choose your action: " << ANSI_BLUE;
            cin >> action;
            cout << ANSI_RESET;
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
                incrementWaitingTimeMenuByDays();
                break;
            case 7:
                incrementWaitingTimeMenuByDate();
                break;
            case 8:
                lateBindingDemoMenu();
                break;
            case 9:
                exitState = true;
                cout << setfill(' ') << setw(55) << ANSI_BLUE << "Goodbye!" << ANSI_RESET << endl;
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

Person enterDataForNewPerson()
{
    std::string firstname;
    std::string lastname;
    std::string occupation;
    string sexCh;
    int salary;

    int day;
    int month;
    int year;

    Person person;
    
    cout << "Enter birthdate year(from 1900 to 2100): " << ANSI_YELLOW;
    cin >> year;
    person.getBirthDate().setYear(year);

    cout << ANSI_RESET << "Enter birthdate month(from 1 to 12): " << ANSI_YELLOW;
    cin >> month;
    person.getBirthDate().setMonth(month);

    int monthDays = Date::getMonthDays(month, year);
    cout << ANSI_RESET << "Enter birthdate day (from 1 to " << monthDays << "): " << ANSI_YELLOW;
    cin >> day;
    person.getBirthDate().setDay(day);

    cout << ANSI_RESET << "Enter firstname: " << ANSI_YELLOW;

    cin.ignore();
    getline(cin, firstname);
    person.setFirstName(firstname);

    cout << ANSI_RESET << "Enter lastname: " << ANSI_YELLOW;

    getline(cin, lastname);
    person.setLastName(lastname);

    cout << ANSI_RESET << "Enter occupation: " << ANSI_YELLOW;

    getline(cin, occupation);
    person.setOccupation(occupation);

    cout << ANSI_RESET << "Enter salary: " << ANSI_YELLOW;
    cin >> salary;
    person.setSalary(salary);

    cout << ANSI_RESET << "Enter sex(m/w): " << ANSI_YELLOW;
    cin >> sexCh;

    cout << ANSI_RESET;
    gender sex = sexCh == "m" ? MALE : FEMALE;
    person.setGender(sex);

    return person;
}

Date enterDataForDate()
{
    int day, month, year;

    Date date;

    cout << ANSI_RESET << "Enter year: " << ANSI_YELLOW;
    cin >> year;
    date.setYear(year);
    cout << ANSI_RESET << "Enter month (from 1 to 12): " << ANSI_YELLOW;
    cin >> month;
    date.setMonth(month);

    int monthDays = Date::getMonthDays(month, year);
    cout << ANSI_RESET << "Enter day: (from 1 to " << monthDays << "): " << ANSI_YELLOW;
    cin >> day;
    date.setDay(day);
    cout << ANSI_RESET;

    return date;
}

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    fillDataForQueue();
    showMainMenu();

    return 0;
}