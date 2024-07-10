def standardfizzbuzz
    start = 1
    finish = 100
    (start..finish).each do |number|
      output = ""
      output << "Fizz" if number % 3 == 0
      output << "Buzz" if number % 5 == 0
      output << number.to_s if output.empty?
      puts output + "\n"
    end
end
def TwistedFizzBuzz
StandardFizzBuzz()