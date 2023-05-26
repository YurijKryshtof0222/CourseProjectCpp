#include "BuildingsQueue.h"

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
	throwIfIndexIsOutOfBounds(index);

	array.erase(array.begin() + index);
}

Person BuildingsQueue::getPerson(int index) const
{
	throwIfIndexIsOutOfBounds(index);

	return array[index].first;
}

Date BuildingsQueue::getWaitingTime(int index) const
{
	throwIfIndexIsOutOfBounds(index);

	return array[index].second;
}

void BuildingsQueue::setPerson(int index, Person person)
{
	throwIfIndexIsOutOfBounds(index);
	
	array[index].first = person;
}

void BuildingsQueue::setWaitingTime(int index, Date date)
{
	throwIfIndexIsOutOfBounds(index);

	array[index].second = date;
}

void BuildingsQueue::sortByTheLengthOfStay()
{
	std::sort(array.begin(), array.end(), utilCompareFunction);
}

bool BuildingsQueue::isIndexOutOfBounds(int index) const
{
	return index < 0 || index > array.size();
}

void BuildingsQueue::throwIfIndexIsOutOfBounds(int index) const
{
	if (isIndexOutOfBounds(index))
		throw new std::runtime_error("Index out of bounds");
}

BuildingsQueue::Iterator BuildingsQueue::begin()
{
	return Iterator(&array[0]);
}

BuildingsQueue::Iterator BuildingsQueue::end()
{
	return Iterator(&array[0] + array.size());
}

BuildingsQueue::Iterator BuildingsQueue::at(int index)
{
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