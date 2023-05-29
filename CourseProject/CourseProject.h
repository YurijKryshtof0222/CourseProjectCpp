#pragma once

#include "Date.h"
#include "Person.h"
#include "BuildingsQueue.h"
#include "IDateStringFormatRetriever.h"

#include <iostream>
#include <iomanip>
#include <windows.h>

void fillDataForQueue();

void showQueueWithIndexRangeMenu();
void sortQueueMenu();
void addNewPersonMenu();
void incrementWaitingTimeMenu();
void removePersonFromQueueMenu();
void lateBindingDemoMenu();
void showMainMenu();

int main();