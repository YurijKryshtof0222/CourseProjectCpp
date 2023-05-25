#pragma once

#include "Person.h"
#include "Date.h"
#include "BuildingsQueueIterator.h"

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
	//class Iterator : std::iterator 
	//<
	//	std::input_iterator_tag,   // iterator_category
	//	std::pair<Person, Date>,   // value_type
	//	std::pair<Person, Date>,   // difference_type
	//	const long*,               // pointer
	//	long                       // reference
	//>
	//{
	//
	//};

	
	static bool utilCompareFunction(std::pair<Person, Date>, std::pair<Person, Date>);
	
	void add(Person, Date);
	void remove(int index);

	Person getPerson(int);
	Date getWaitingTime(int);

	void setPerson(int, Person);
	void setWaitingTime(int, Date);

	void sortByTheLengthOfStay();

	BuildingsQueueIterator begin();
	BuildingsQueueIterator end();

	friend std::ostream& operator << (std::ostream& os, BuildingsQueue& date);
};