#pragma once

#include "IDateStringFormatRetriever.h"

#include <iostream>
#include <string>
#include <map>

class Date : public IDateStringFormatRetriever
{
private:
    static std::map<int, int> monthDaysMap;
    static std::map<int, int> initMonthDaysMap();
    
    int day;
    int month;
    int year;
public:
    static int getMonthDays(int month, int year);

    static void validateDay(int day, int month, int year);
    static void validateMonth(int month);
    static void validateYear(int year);

    static void validateAll(int day, int month, int year);
    
    Date();
    Date(int day, int month, int year);
    Date(const Date& other);

    ~Date();

    int getDay() const;
    int getMonth() const;
    int getYear() const;

    std::string dateToString() const override;

    void setDay(int day);
    void setMonth(int month);
    void setYear(int year);


    void addDays(int);
    void addMonths(int);
    void addYears(int);

    void substrDays(int);
    void substrMonths(int);
    void substrYears(int);

    void operator += (int days);
    void operator -= (int days);

    void operator += (const Date&);
    void operator -= (const Date&);

    void operator = (const Date&);
    bool operator > (const Date&);
    bool operator < (const Date&);

    friend std::ostream& operator << (std::ostream& os, const Date& date);
    friend std::istream& operator >> (std::istream& os, Date& date);
};