#include <iostream>

#include "Date.h"
#include "Person.h"

Person::Person() : Person(Date(15, 1, 1990), "John", "Doe", "driver", 20000, true)
{
}

Person::Person(Date birthdate, std::string firstname, std::string lastname, std::string occupation, int salary, bool sex) 
	: Date(birthdate)
{
	this->firstname = firstname;
	this->lastname = lastname;
	this->occupation = occupation;
	this->salary = salary;
	this->sex = sex;
}

Person::~Person() {}

std::string Person::dateToString() const
{
	return  std::to_string(getYear())
		+ "_" + std::to_string(getMonth())
		+ "_" + std::to_string(getDay());
}

std::string Person::fullname() const
{
	return firstname + " " + lastname;
}

void Person::setFirstName(const std::string& firstname)
{
	if (&firstname == nullptr || firstname.empty())
		throw std::runtime_error("Firstname value must be not empty!");
	this->firstname = firstname;
}

void Person::setLastName(const std::string& lastname)
{
	if (&lastname == nullptr || lastname.empty())
		throw std::runtime_error("Lastname value must be not empty!");
	this->lastname = lastname;
}

void Person::setOccupation(const std::string& occupation)
{
	if (&occupation == nullptr || occupation.empty())
		throw std::runtime_error("Lastname value must be not empty!");;
	this->occupation = occupation;
}

void Person::setSalary(int salary)
{
	if (salary < 0)
		throw std::runtime_error("Salary value must be greater than negative number!");
	this->salary = salary;
}

void Person::setSex(bool sex)
{
	this->sex = sex;
}

std::string Person::getFirstName() const
{
	return firstname;
}

std::string Person::getLastName() const
{
	return lastname;
}

std::string Person::getOccupation() const
{
	return occupation;
}

int Person::getSalary() const
{
	return salary;
}

bool Person::getSex() const
{
	return sex;
}

std::ostream& operator << (std::ostream& os, const Person& person)
{
	os << "Surname: " << person.lastname << std::endl;
	os << "Name: " << person.firstname << std::endl;
	os << "Birthdate: " << person.dateToString() << std::endl;

	os << "Sex: " << (person.sex ? "Male" : "Female") << std::endl;
	os << "Salary: " << person.salary << std::endl;
	os << "Occupation: " << person.occupation << std::endl;

	return os;
}

std::istream& operator >> (std::istream& is, Person& person)
{
	std::string firstname;
	std::string lastname;
	std::string occupation;
	bool sex;
	int salary;

	int day;
	int month;
	int year;
	
	using namespace std;

	cout << "Enter person birthdate day: ";
	is >> day;
	cout << "Enter person birthdate month: ";
	is >> month;
	person.setMonth(month);
	person.setDay(day);
	cout << "Enter person birthdate year: ";
	is >> year;
	person.setYear(year);
	cout << "Enter person firstname: ";
	is >> firstname;
	person.setFirstName(firstname);
	cout << "Enter person lastname: ";
	is >> lastname;
	person.setLastName(lastname);
	cout << "Enter person occupation: ";
	is >> occupation;
	person.setOccupation(occupation);
	cout << "Enter person salary: ";
	is >> salary;
	person.setSalary(salary);
	cout << "Enter person sex: ";
	is >> sex;
	person.setSex(sex);

	return is;
}
