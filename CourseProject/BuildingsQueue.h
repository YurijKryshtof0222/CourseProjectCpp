#pragma once

#include "Person.h"
#include "Date.h"

#include <vector>
#include <utility> //for pair struct
#include <string>
#include <algorithm> //for sort function

class BuildingsQueue
{
	using personDatePair = std::pair<Person, Date>;
private:
	std::vector<personDatePair> array;
public:
	class Iterator
	{
	public:
		using iterator_category = std::forward_iterator_tag;
		using difference_type	= std::ptrdiff_t;
		using value_type		= personDatePair;
		using pointer			= personDatePair*;
		using reference			= personDatePair&;

		Iterator(pointer ptr) : m_ptr(ptr) {}
		Iterator() : m_ptr(nullptr) {}

		reference operator * () const { return *m_ptr; }
		pointer	  operator  -> () { return m_ptr; }

		Iterator& operator ++ () { m_ptr++; return *this; }
		Iterator  operator ++ (int) { Iterator tmp = *this; ++(*this); return tmp; }

		friend bool operator == (const Iterator& a, const Iterator& b) { return a.m_ptr == b.m_ptr; };
		friend bool operator != (const Iterator& a, const Iterator& b) { return a.m_ptr != b.m_ptr; };
	private:
		pointer m_ptr;
	};

	BuildingsQueue() = default;
	~BuildingsQueue();

	static bool utilCompareFunction(personDatePair, personDatePair);
	
	void add(Person, Date);
	void remove(int index);

	Person getPerson(int index)			const;
	Date getWaitingTime(int index)		const;

	void setPerson(int index, Person);
	void setWaitingTime(int index, Date);

	void sortByTheLengthOfStay();

	bool isIndexOutOfBounds(int)		const;

	Iterator begin();
	Iterator end();
	Iterator at(int);

	friend std::ostream& operator << (std::ostream& os, BuildingsQueue& date);

	
};