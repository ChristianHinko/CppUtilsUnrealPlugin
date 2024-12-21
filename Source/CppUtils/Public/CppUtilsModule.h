// Copyright (c) 2023-2024 Christian Hinkle, Brian Hinkle.

#pragma once

#include "Modules/ModuleInterface.h"
#include "Modules/ModuleManager.h"

class FCppUtilsModule : public FDefaultModuleImpl
{
public:
    virtual void StartupModule() override;
    virtual void ShutdownModule() override;
};
