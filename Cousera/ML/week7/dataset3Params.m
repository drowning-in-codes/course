function [C, sigma] = dataset3Params(X, y, Xval, yval)
%DATASET3PARAMS returns your choice of C and sigma for Part 3 of the exercise
%where you select the optimal (C, sigma) learning parameters to use for SVM
%with RBF kernel
%   [C, sigma] = DATASET3PARAMS(X, y, Xval, yval) returns your choice of C and 
%   sigma. You should complete this function to return the optimal C and 
%   sigma based on a cross-validation set.
%

% You need to return the following variables correctly.
C = 1;
sigma = 0.3;

% ====================== YOUR CODE HERE ======================
% Instructions: Fill in this function to return the optimal C and sigma
%               learning parameters found using the cross validation set.
%               You can use svmPredict to predict the labels on the cross
%               validation set. For example, 
%                   predictions = svmPredict(model, Xval);
%               will return the predictions on the cross validation set.
%
%  Note: You can compute the prediction error using 
%        mean(double(predictions ~= yval))
%
all_C = [0.01 0.03 0.1 0.3 1 3 10 30];
all_sigma = [0.01 0.03 0.1 0.3 1 3 10 30];
error_rate = zeros(64,1);
for i=1:8
  for j=1:8
    model= svmTrain(X, y,all_C(i), @(x1, x2) gaussianKernel(x1, x2, all_sigma(j))); 
    predictions = svmPredict(model, Xval);
    error_rate((i-1)*8+j) = mean(double(predictions ~= yval));
  endfor
endfor
[x,index] = min(error_rate);
# fprintf("index=%d",index);
sigma = mod(index,8);
C = (index-sigma)/8;
if sigma == 0,
  sigma = 8;
end
sigma = all_sigma(sigma);
C = all_C(C);
# fprintf("C=%.3f  sigma=%.3f",C,sigma);








% =========================================================================

end
