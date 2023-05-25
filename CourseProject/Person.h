#pragma once

#include "Date.h"
#include "string.h"

class Person : private Date
{
private:
	std::string firstname;
	std::string lastname;
	std::string occupation;
	int salary;
	bool sex;

public:
	Person();
	
	Person(Date birthdate,
		std::string firstname,
		std::string lastname,
		std::string occupation,
		int salary,
		bool sex);

	~Person();

	virtual std::string dateToString() const;

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
	friend std::istream& operator >> (std::istream& is, Person& date);
};