#pragma once

#include <string>

class IDateStringFormatRetriever 
{
public:
	virtual std::string dateToString() const = 0;
};