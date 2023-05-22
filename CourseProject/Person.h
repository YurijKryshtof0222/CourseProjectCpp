#pragma once

#include "Date.h"
#include "string.h"

class Person : public Date
{
private:
	std::string firstname;
	std::string lastname;
	std::string occupation;
	int salary;
	bool sex;

public:
	Person(Date birthdate,
		std::string firstname,
		std::string lastname,
		std::string occupation,
		int salary,
		bool sex);

	~Person();

	virtual int getDay() const;
	virtual int getMonth() const;
	virtual int getYear() const;

	// ������ ������������ ������� ����
	virtual void setDay(int day);
	virtual void setMonth(int month);
	virtual void setYear(int year);

	void setFirstName(const std::string&);
	void setLastName(const std::string&);
	void setOccupation(const std::string&);
	void setSalary(int);
	void setSex(bool);

	std::string getFirstName();
	std::string getLastName();
	std::string getOccupation();
	int  getSalary();
	bool getSex();

	std::string fullname() const;

	friend std::ostream& operator << (std::ostream& os, const Person& date);
	friend std::istream& operator >> (std::istream& os, Person& date);
};