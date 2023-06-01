#include "BuildingsQueue.h"

BuildingsQueue::BuildingsQueue()
{}

BuildingsQueue::~BuildingsQueue()
{}

bool BuildingsQueue::utilCompareFunction(personDatePair i, personDatePair j)
{
	return i.second > j.second;
}

void BuildingsQueue::add(Person person, Date date)
{
	if (person.getBirthDate() > date)
		throw std::runtime_error("birthdate cannot be later than waiting time date!");
	
	array.push_back(personDatePair(person, date));
}

void BuildingsQueue::remove(int index)
{
	if (isIndexOutOfBounds(index))
		throw std::runtime_error("index is out of bounds");

	array.erase(array.begin() + index);
}

Person BuildingsQueue::getPerson(int index)
{
	if (isIndexOutOfBounds(index))
		throw std::runtime_error("index is out of bounds");

	return array[index].first;
}

Date BuildingsQueue::getWaitingTime(int index)
{
	if (isIndexOutOfBounds(index))
		throw std::runtime_error("index is out of bounds");

	return array[index].second;
}

void BuildingsQueue::setPerson(int index, Person person)
{
	if (isIndexOutOfBounds(index))
		throw std::runtime_error("index is out of bounds");
	
	array[index].first = person;
}

void BuildingsQueue::setWaitingTime(int index, Date date)
{
	if (isIndexOutOfBounds(index))
		throw std::runtime_error("index is out of bounds");
	if (array[index].first.getBirthDate() > date)
		throw std::runtime_error("birthdate cannot be later than waiting time date!");

	array[index].second = date;
}

void BuildingsQueue::sortByTheLengthOfStay()
{
	std::sort(array.begin(), array.end(), utilCompareFunction);
}

bool BuildingsQueue::isIndexOutOfBounds(int index) 
{
	return index < 0 || index > array.size();
}
 
BuildingsQueue::Iterator BuildingsQueue::begin() 
{
	if (array.empty()) {
		throw std::runtime_error("index is out of bounds");
	}
	
	return Iterator(&array[0]);
}

BuildingsQueue::Iterator BuildingsQueue::end() 
{
	if (array.empty()) {
		throw std::runtime_error("index is out of bounds");
	}
	
	return Iterator(&array[0] + array.size());
}

BuildingsQueue::Iterator BuildingsQueue::at(int index) 
{
	if (isIndexOutOfBounds(index))
		throw std::runtime_error("index is out of bounds");
	
	return Iterator(&array[0] + index);
}

std::ostream& operator << (std::ostream& os, BuildingsQueue& buildingsQueue)
{
	using namespace std;
	
	int i = 1;
	os << "Buildings Queue { " << endl;
	for (auto& iter : buildingsQueue)
	{
		os << i++ << ".) "	   << iter.first
		   << "Waiting Time: " << iter.second << endl << endl;
	}
	/*for (auto iter = buildingsQueue.array.begin(); iter != buildingsQueue.array.end(); iter++)
	{
		os << i++ << ".) "	   << iter->first
		   << "Waiting Time: " << iter->second << endl;
	}*/
	os << "}" << endl;
	return os;
}