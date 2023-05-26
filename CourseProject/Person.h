#pragma once

#include "Date.h"

#include <iostream>
#include <string>

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

	std::string dateToString() const override;

	void setFirstName(const std::string&);
	void setLastName(const std::string&);
	void setOccupation(const std::string&);
	void setSalary(int);
	void setSex(bool);

	std::string getFirstName()  const;
	std::string getLastName()   const;
	std::string getOccupation() const;
	int  getSalary()			const;
	bool getSex()				const;

	std::string fullname() const;

	friend std::ostream& operator << (std::ostream& os, const Person& date);
	friend std::istream& operator >> (std::istream& is, Person& date);
};