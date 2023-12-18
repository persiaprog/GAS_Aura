// Copyright Ali Amanzadegan

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Character.h"
#include "AuroCharacterBase.generated.h"

UCLASS(Abstract)
class LEARNGAS_API AAuroCharacterBase : public ACharacter
{
	GENERATED_BODY()

public:
	AAuroCharacterBase();

protected:
	virtual void BeginPlay() override;

};
