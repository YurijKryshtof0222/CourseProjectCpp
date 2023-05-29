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

    static int getDaysByMonth(int month);

    static void validateDay(int month, int day);
    static void validateMonth(int month);
    static void validateYear(int year);

    static void validateAll(int day, int month, int year);
    
    int day;
    int month;
    int year;
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

    std::string dateToString() const override;

    // методи встановлення значень полів
    void setDay(int day);
    void setMonth(int month);
    void setYear(int year);

    void operator += (int days);
    void operator -= (int days);

    void operator = (const Date&);
    bool operator > (const Date&);
    bool operator < (const Date&);

    friend std::ostream& operator << (std::ostream& os, const Date& date);
    friend std::istream& operator >> (std::istream& os, Date& date);
};