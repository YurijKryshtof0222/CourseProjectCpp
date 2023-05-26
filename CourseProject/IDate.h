#pragma once

#include <string>

class IDate {
public:
	virtual std::string dateToString() const = 0;
};