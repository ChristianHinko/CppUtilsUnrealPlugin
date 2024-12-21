// Copyright (c) 2023-2024 Christian Hinkle, Brian Hinkle.

#include "CppUtilsModule.h"

void FCppUtilsModule::StartupModule()
{
    FDefaultModuleImpl::StartupModule();
}

void FCppUtilsModule::ShutdownModule()
{
    FDefaultModuleImpl::ShutdownModule();
}

IMPLEMENT_MODULE(FCppUtilsModule, CppUtils)
