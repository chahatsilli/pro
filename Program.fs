open System

// Salaries list
let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

// 1.
let highIncomeSalaries = salaries |> List.filter (fun x -> x > 100000)
printfn "Actual Salaries: %A" salaries
printfn "High-income salaries: %A" highIncomeSalaries

// 2. 
printfn "Actual Salaries: %A" salaries
let calculateTax (salary: int) =
    match salary with
    | _ when salary <= 49020 -> float salary * 0.10
    | _ when salary <= 100000 -> float salary * 0.20
    | _ -> float salary * 0.30

let taxes = salaries |> List.map calculateTax
printfn "Taxes for each salary: %A" taxes

// 3. Add $20,000 to salaries less than $49,020 using the map function
printfn "Actual Salaries: %A" salaries
let adjustedSalaries = salaries |> List.map (fun x -> if x < 49020 then x + 20000 else x)
printfn "Adjusted salaries: %A" adjustedSalaries

// 4. Sum of salaries between $50,000 and $100,000 using reduce/fold
printfn "Actual Salaries: %A" salaries
let salariesBetween = salaries |> List.filter (fun x -> x >= 50000 && x <= 100000)
let sumOfSalariesBetween = salariesBetween |> List.fold (+) 0
printfn "Sum of salaries between $50,000 and $100,000: %d" sumOfSalariesBetween


// Tail-recursive function to calculate the sum of all multiples of 3 up to a given number

let sumOfMultiplesOf3 limit =
    let rec helper current acc =
        if current > limit then acc // Base case: when current exceeds the limit, return accumulated sum
        else helper (current + 3) (acc + current) // Recursive call, incrementing by 3 and adding to the accumulator
    helper 3 0 // Start with the first multiple of 3 and an accumulator of 0

// Test the function
let result = sumOfMultiplesOf3 27
printfn "output 2:"
printfn "Sum of multiples of 3 up to 27: %d" result

