#pragma once

#include "Person.h"
#include "Date.h"

#include <vector>
#include <utility> //for pair struct
#include <string>
#include <algorithm> //for sort function

class BuildingsQueue
{
private:
	std::vector<std::pair<Person, Date>> array;
public:
	class Iterator
	{
	public:
		using iterator_category = std::forward_iterator_tag;
		using difference_type	= std::ptrdiff_t;
		using value_type		= std::pair<Person, Date>;
		using pointer			= std::pair<Person, Date>*;
		using reference			= std::pair<Person, Date>&;

		Iterator(pointer ptr) : m_ptr(ptr) {}

		reference operator * () const { return *m_ptr; }
		pointer	  operator  -> () { return m_ptr; }

		Iterator& operator ++ () { m_ptr++; return *this; }
		Iterator  operator  ++ (int) { Iterator tmp = *this; ++(*this); return tmp; }

		friend bool operator == (const Iterator& a, const Iterator& b) { return a.m_ptr == b.m_ptr; };
		friend bool operator != (const Iterator& a, const Iterator& b) { return a.m_ptr != b.m_ptr; };
	private:
		pointer m_ptr;
	};

	static bool utilCompareFunction(std::pair<Person, Date>, std::pair<Person, Date>);
	
	void add(Person, Date);
	void remove(int index);

	Person getPerson(int)			const;
	Date getWaitingTime(int)		const;

	void setPerson(int, Person);
	void setWaitingTime(int, Date);

	void sortByTheLengthOfStay();

	bool isIndexOutOfBounds(int)		const;
	void throwIfIndexIsOutOfBounds(int) const;

	Iterator begin();
	Iterator end();
	Iterator at(int);

	friend std::ostream& operator << (std::ostream& os, BuildingsQueue& date);
};