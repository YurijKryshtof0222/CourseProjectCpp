#include <iostream>

#include "Date.h"
#include "Person.h"

Person::Person() : Person(Date(15, 1, 1990), "John", "Doe", "driver", 20000, MALE)
{
}

Person::Person(Date birthdate, std::string firstname, std::string lastname, std::string occupation, int salary, gender sex)
	: birthdate(birthdate),
	firstname(firstname),
	lastname(lastname),
	occupation(occupation),
	salary(salary),
	sex(sex)
{}

Person::~Person() {}

std::string Person::dateToString() const
{
	return  std::to_string(birthdate.getYear())
		+ "_" + (birthdate.getMonth() < 10 ? "0" : "")
		+       std::to_string(birthdate.getMonth())
		+ "_" + std::to_string(birthdate.getDay());
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

void Person::setGender(gender sex)
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

gender Person::getGender() const
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
	char sexCh;
	int salary;

	int day;
	int month;
	int year;
	
	using namespace std;

	cout << "Enter birthdate year: ";
	is >> year;
	person.birthdate.setYear(year);
	cout << "Enter birthdate month: ";
	is >> month;
	person.birthdate.setMonth(month);
	cout << "Enter birthdate day: ";
	is >> day;
	person.birthdate.setDay(day);

	cout << "Enter firstname: ";
	/*is >> firstname;*/
	is.ignore();
	getline(is, firstname);
	person.setFirstName(firstname);

	cout << "Enter lastname: ";
	/*is >> lastname;*/
	is.ignore();
	getline(is, lastname);
	person.setLastName(lastname);

	cout << "Enter occupation: ";
	/*is >> occupation;*/
	is.ignore();
	getline(is, occupation);
	person.setOccupation(occupation);

	cout << "Enter salary: ";
	is >> salary;
	person.setSalary(salary);

	cout << "Enter sex(m/w): ";
	is >> sexCh;

	gender sex = sexCh == 'm' ? MALE : FEMALE;
	person.setGender(sex);

	return is;
}
