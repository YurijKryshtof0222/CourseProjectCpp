#include "Date.h"

std::map<int, int> Date::monthDaysMap = initMonthDaysMap();

std::map<int, int> Date::initMonthDaysMap()
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

Date::Date()
{
    day = 1;
    month = 1;
    year = 1900;
}

Date::Date(int d, int m, int y) : day(d), month(m), year(y)
{
    validateAll(d, m, y);

    /*this->day = d;
    this->month = m;
    this->year = y;*/
}

Date::Date(const Date& other)
{ 
    this->day = other.day;
    this->month = other.month;
    this->year = other.year;
}

Date::~Date() {}

int Date::getMonthDays(int month, int year)
{
    validateMonth(month);
    validateYear(year);
    
    int result = monthDaysMap.at(month);
    //for checking leap year
    if (month == 2 && ((year % 400 == 0) || ((year % 100 != 0) && (year % 4 == 0))))
        result++;
    return result;
}

void Date::validateDay(int day, int month, int year)
{
    if (day < 1 || day > getMonthDays(month, year))
        throw std::runtime_error("Incorrect day value!");
}

void Date::validateMonth(int month)
{
    if (month < 1 || month > 12)
        throw std::runtime_error("Incorrect month value!");
}

void Date::validateYear(int year)
{
    if (year < 1900 || year > 2100)
        throw std::runtime_error("Incorrect year value!");
}

void Date::validateAll(int day, int month, int year)
{
    validateYear(year);
    validateMonth(month);
    validateDay(day, month, year);
}

// Методи налаштування значень полів
void Date::setDay(int day)
{
    validateDay(day, month, year);
    this->day = day;
}

void Date::setMonth(int month) 
{
    validateMonth(month);
    this->month = month;
}

void Date::setYear(int year) 
{
    validateYear(year);
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
    return      (day < 10 ? "0" : "")
        + std::to_string(day)
        + "." + (month < 10 ? "0" : "")
        + std::to_string(month)
        + "." + std::to_string(year);
}

void Date::addDays(int days)
{
    if (days < 0)
        this->substrDays(-days);
    else if (this->day + days <= Date::getMonthDays(month, year))
        this->day += days;
    else
    {
        int prevMonthDays = Date::getMonthDays(month, year);
        if (this->month < 12)
            this->month++;
        else
        {
            this->month = 1;
            setYear(year + 1);
        }
        int remainder = prevMonthDays - this->day;
        this->day = 1;

        this->addDays(days - remainder - 1);
    }
}

void Date::addMonths(int months)
{
    if (months < 0)
    {
        this->substrMonths(-months);
        return;
    }
    
    this->month = this->month + months;
    if (this->month + months > 12)
    {
        validateYear(this->year + 1);
        this->setYear(this->year + 1);
        this->month -= 12;
        this->addYears(months - 12);
    }
}

void Date::addYears(int years)
{
    this->setYear(this->year + years);
}

void Date::substrDays(int days)
{
    if (days < 0)
        this->addDays(-days);
    else if (this->day - days >= 1)
        this->day -= days;
    else
    {
        int prevMonthDays = Date::getMonthDays(month, year);
        if (this->month > 1)
            this->month--;
        else
        {
            this->month = 12;
            setYear(year - 1);
        }
        int remainder = days - this->day;
        this->day = Date::getMonthDays(month, year);

        this->substrDays(remainder);
    }
}

void Date::substrMonths(int months)
{
    if (months < 0)
    {
        this->addYears(-month);
        return;
    }
    
    this->month = this->month - months;
    if (this->month - months <= 0)
    {
        validateYear(this->year - 1);
        this->setYear(this->year - 1);
        this->month = 12;
        this->substrMonths(months - 12);
    }
}

void Date::substrYears(int years)
{
    this->setYear(this->year - years);
}


void Date::operator += (int days)
{
    this->addDays(days);
}

void Date::operator -= (int days)
{
    this->substrDays(days);
}

void Date::operator+=(const Date& other)
{
    this->addDays(other.day);
    this->addMonths(other.month);
    //this->addYears(other.year);
}

void Date::operator-=(const Date& other)
{
    this->substrDays(other.day);
    this->substrMonths(other.month);
    //this->substrYears(other.year);
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
    int day, month, year;
    
    is >> year;
    date.setYear(year);
    is >> month;
    date.setMonth(month);
    is >> day;
    date.setDay(day);
       
    return is;
}