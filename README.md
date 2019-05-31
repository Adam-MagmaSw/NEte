# NEte
NEte is a BDD framework specifically aimed at end-to-end test scenarios.

Typically end-to-end tests are expensive and unreliable, NEte aims to tackle these issues by:
* Allowing asserts to be retried for a specified number of times
* Allowing tests to specify asserts as either non-critical or critical, where if a critical assert fails the test will stop immediately but if a non-critical assert fails the test will continue but report failure at the end
* Allowing whole sections of tests to be re-executed a set number of times if a critical assert fails
