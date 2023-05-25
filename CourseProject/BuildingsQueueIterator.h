#pragma once

#include <iterator>
#include "Date.h"
#include "Person.h"

class BuildingsQueueIterator
{
public:

    using iterator_category = std::forward_iterator_tag;
    using difference_type = std::ptrdiff_t;
    using value_type = std::pair<Person, Date>;
    using pointer = std::pair<Person, Date>*;
    using reference = std::pair<Person, Date>&;

    BuildingsQueueIterator(pointer ptr) : m_ptr(ptr) {}

    reference operator*() const { return *m_ptr; }
    pointer operator->() { return m_ptr; }

    BuildingsQueueIterator& operator++() { m_ptr++; return *this; }

    BuildingsQueueIterator operator++(int) { BuildingsQueueIterator tmp = *this; ++(*this); return tmp; }

    friend bool operator == (const BuildingsQueueIterator& a, const BuildingsQueueIterator& b) { return a.m_ptr == b.m_ptr; };
    friend bool operator != (const BuildingsQueueIterator& a, const BuildingsQueueIterator& b) { return a.m_ptr != b.m_ptr; };

private:

    pointer m_ptr;
};