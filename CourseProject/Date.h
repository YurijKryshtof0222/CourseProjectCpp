#pragma once

#include <iostream>
#include <string>
#include <map>

class Date 
{
private:
    int day;
    int month;
    int year;

    class Validator
    {
    private:
        static std::map<int, int> monthDaysMap;
        static std::map<int, int> initMonthDaysMap();
    public:
        static int getDaysByMonth(int month);
        
        Validator();

        void validateDay(int month, int day);
        void validateMonth(int month);
        void validateYear(int year);

        void validateAll(int day, int month, int year);
    };

    Validator validator;
public:
    // конструктори
    Date();
    Date(int day, int month, int year);
    Date(const Date& other);

    // деструктор
    ~Date();

    // методи отримання значень полів
    int getDay() const;
    int getMonth() const;
    int getYear() const;

    virtual std::string dateToString() const;

    // методи встановлення значень полів
    void setDay(int day);
    void setMonth(int month);
    void setYear(int year);

    void operator += (int days);
    void operator -= (int days);

    void operator = (const Date& other);
    bool operator > (const Date&);

    friend std::ostream& operator << (std::ostream& os, const Date& date);
    friend std::istream& operator >> (std::istream& os, Date& date);
};