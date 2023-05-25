#include "BuildingsQueue.h"
#include <list>
#include <algorithm>
#include <iostream>

bool BuildingsQueue::utilCompareFunction(std::pair<Person, Date> i, std::pair<Person, Date> j)
{
	return i.second > j.second;
}

void BuildingsQueue::add(Person person, Date date)
{
	array.push_back(std::pair<Person, Date>(person, date));
}

void BuildingsQueue::remove(int index)
{
	if (index < 0 || index > array.size())
		throw std::runtime_error("Element Index is out of bounds");

	array.erase(array.begin() + index);
}

Person BuildingsQueue::getPerson(int index)
{
	return array[index].first;
}

Date BuildingsQueue::getWaitingTime(int index)
{
	return array[index].second;
}

void BuildingsQueue::setPerson(int index, Person person)
{
	array[index].first = person;
}

void BuildingsQueue::setWaitingTime(int index, Date date)
{
	array[index].second = date;
}

void BuildingsQueue::sortByTheLengthOfStay()
{
	std::sort(array.begin(), array.end(), utilCompareFunction);
}

BuildingsQueueIterator BuildingsQueue::begin()
{
	return BuildingsQueueIterator(&array[0]);
}

BuildingsQueueIterator BuildingsQueue::end()
{
	return BuildingsQueueIterator(&array[0] + array.size());
}

//TVShowProgramIterator TVShowProgram::begin()
//{;
//    return TVShowProgramIterator(&shows[0]);
//}
//
//TVShowProgramIterator TVShowProgram::end()
//{
//    return TVShowProgramIterator(&shows[0] + shows.size());
//}

std::ostream& operator << (std::ostream& os, BuildingsQueue& buildingsQueue)
{
	using namespace std;
	
	int i = 1;
	os << "Buildings Queue { " << endl;
	for (auto iter : buildingsQueue)
	{
		os << i++ << ".) " << iter.first
			<< "Waiting Time: " << iter.second << endl;
	}
	/*for (auto iter = buildingsQueue.array.begin(); iter != buildingsQueue.array.end(); iter++)
	{
		os << i++ << ".) "	   << iter->first
		   << "Waiting Time: " << iter->second << endl;
	}*/
	os << "}" << endl;
	return os;
}