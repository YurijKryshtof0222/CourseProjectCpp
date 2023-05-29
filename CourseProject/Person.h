#pragma once

#include "Date.h"
#include "IDateStringFormatRetriever.h"
#include "gender.h"

#include <iostream>
#include <string>


class Person : public IDateStringFormatRetriever
{
private:
	Date birthdate;
	std::string firstname;
	std::string lastname;
	std::string occupation;
	int salary;
	gender sex;

public:
	Person();
	
	Person(Date birthdate,
		std::string firstname,
		std::string lastname,
		std::string occupation,
		int salary,
		gender sex);

	~Person();

	std::string dateToString() const override;

	void setBirthDate(const Date);
	void setFirstName(const std::string&);
	void setLastName(const std::string&);
	void setOccupation(const std::string&);
	void setSalary(int);
	void setGender(gender);

	Date getBirthDate()			const;
	std::string getFirstName()  const;
	std::string getLastName()   const;
	std::string getOccupation() const;
	int  getSalary()			const;
	gender getGender()			const;

	std::string fullname() const;

	friend std::ostream& operator << (std::ostream& os, const Person& date);
	friend std::istream& operator >> (std::istream& is, Person& date);
};