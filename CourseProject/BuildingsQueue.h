#pragma once

#include "Person.h"
#include "Date.h"

#include <vector>
#include <utility> //for pair struct
#include <string>
#include <algorithm>
#include <iterator>

class BuildingsQueue
{
private:
	std::vector<std::pair<Person, Date>> array;
public:
	static bool utilCompareFunction(std::pair<Person, Date>, std::pair<Person, Date>);
	
	void add(Person, Date);
	void remove(int index);

	Person getPerson(int);
	Date getWaitingTime(int);

	void setPerson(int, Person);
	void setWaitingTime(int, Date);

	void sortByTheLengthOfStay();

	auto beginIterator();
	auto endIterator();

	friend std::ostream& operator << (std::ostream& os, const BuildingsQueue& date);
};