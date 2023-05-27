#include "Date.h"

std::map<int, int> Date::Validator::monthDaysMap = initMonthDaysMap();

std::map<int, int> Date::Validator::initMonthDaysMap()
{
    std::map<int, int> monthDaysMap;
    monthDaysMap.emplace(std::make_pair(1, 31));  //JANUARY
    monthDaysMap.emplace(std::make_pair(2, 28));  //FEBRUARY
    monthDaysMap.emplace(std::make_pair(3, 31));  //MARCH
    monthDaysMap.emplace(std::make_pair(4, 30));  //APRIL
    monthDaysMap.emplace(std::make_pair(5, 31));  //MAY
    monthDaysMap.emplace(std::make_pair(6, 30));  //JUNE
    monthDaysMap.emplace(std::make_pair(7, 31));  //JULY
    monthDaysMap.emplace(std::make_pair(8, 31));  //AUGUST
    monthDaysMap.emplace(std::make_pair(9, 30));  //SEPTEMBER
    monthDaysMap.emplace(std::make_pair(10, 31)); //OCTOBER
    monthDaysMap.emplace(std::make_pair(11, 30)); //NOVEMBER
    monthDaysMap.emplace(std::make_pair(12, 31)); //DECEMBER
    return monthDaysMap;
}

Date::Date() : validator()
{
    day = 1;
    month = 1;
    year = 1900;
}

Date::Date(int d, int m, int y) : day(d), month(m), year(y), validator()
{
    validator.validateAll(d, m, y);

    /*this->day = d;
    this->month = m;
    this->year = y;*/
}

Date::Date(const Date& other) : validator()
{ 
    this->day = other.day;
    this->month = other.month;
    this->year = other.year;
}

Date::~Date() {}

int Date::Validator::getDaysByMonth(int month)
{
    return monthDaysMap.at(month);
}

Date::Validator::Validator()
{
    
}

void Date::Validator::validateDay(int month, int day)
{
    if (day < 1 || day > monthDaysMap.at(month))
        throw std::runtime_error("Incorrect day value!");
}

void Date::Validator::validateMonth(int month)
{
    if (month < 1 || month > 12)
        throw std::runtime_error("Incorrect month value!");
}

void Date::Validator::validateYear(int year)
{
    if (year < 1900 || year > 2100)
        throw std::runtime_error("Incorrect year value!");
}

void Date::Validator::validateAll(int day, int month, int year)
{
    validateMonth(month);
    validateDay(month, day);
    validateYear(year);
}

// Методи налаштування значень полів
void Date::setDay(int day)
{
    validator.validateDay(month, day);
    this->day = day;
}

void Date::setMonth(int month) 
{
    validator.validateMonth(month);
    this->month = month;
}

void Date::setYear(int year) 
{
    validator.validateYear(year);
    this->year = year;
}

// Методи отримання значень полів
int Date::getDay() const 
{
    return day;
}

int Date::getMonth() const 
{
    return month;
}

int Date::getYear() const 
{
    return year;
}

std::string Date::dateToString() const
{
    return std::to_string(day) 
        + "." + (month < 10 ? "0" : "") 
              + std::to_string(month)
        + "." + std::to_string(year);
} 

void Date::operator += (int days)
{
    if (days < 0) 
        *this -= (-days);
    else if (this->day + days <= Date::Validator::getDaysByMonth(month))
        this->day += days;
    else 
    {
        int prevMonthDays = Date::Validator::getDaysByMonth(month);
        if (this->month < 12)
            this->month++;
        else 
        {
            this->month = 1;
            setYear(year + 1);
        }
        int remainder = prevMonthDays - this->day;
        this->day = 1;
       
        *this += days - remainder - 1;
    }

}

void Date::operator -= (int days)
{
    if (days < 0)
        *this += (-days);
    else if (this->day - days >= 1)
        this->day -= days;
    else
    {
        int prevMonthDays = Date::Validator::getDaysByMonth(month);
        if (this->month > 1)
            this->month--;
        else
        {
            this->month = 12;
            setYear(year - 1);
        }
        int remainder = days - this->day;
        this->day = Date::Validator::getDaysByMonth(month);

        *this -= remainder;
    }
}

void Date::operator = (const Date& other)
{
    this->day = other.day;
    this->month = other.month;
    this->year = other.year;
}

bool Date::operator > (const Date& another)
{
    if (this->year != another.year) return this->year > another.year;
    if (this->month != another.month) return this->month > another.month;
    return this->day > another.day;
}

bool Date::operator < (const Date& another)
{
    if (this->year != another.year) return this->year < another.year;
    if (this->month != another.month) return this->month < another.month;
    return this->day < another.day;
}

std::ostream& operator << (std::ostream& os, const Date& date)
{
    os << date.dateToString();
    return os;
}

std::istream& operator >> (std::istream& is, Date& date)
{    
    using namespace std;
    
    int day, month, year;
    
    try 
    {
        cout << "Enter day: ";
        is >> day;
        cout << "Enter month: ";
        is >> month;
        date.setMonth(month);
        date.setDay(day);
        cout << "Enter year: ";
        is >> year;
        date.setYear(year);
       
        return is;
    }

    catch (std::runtime_error& e)
    {
        std::cerr << e.what() << std::endl;
    }
    
}