#pragma once

#include "Date.h"
#include "Person.h"
#include "BuildingsQueue.h"

#include <iostream>
#include <iomanip>
#include <windows.h>

void fillDataForQueue();
void showWithIndexRange();
void sort();
void addNewPerson();
void incrementWaitingTime();
void removePersonFromQueue();
void showMenu();

int main();